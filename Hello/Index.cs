using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;
using System.Device.Location;

namespace Hello
{
    public partial class Index : Form
    {
        private string BluetoothReceviedData;
        BluetoothAddress address = null;//蓝牙地址
        SerialPort my = new SerialPort();
        string gpstext = "";
        double dis;

        public Index()
        {
            InitializeComponent();


            Control.CheckForIllegalCrossThreadCalls = false;//工作线程不能访问窗口线程
            this.FormBorderStyle = FormBorderStyle.Sizable;// 显示任务栏
            this.WindowState = FormWindowState.Maximized;// 窗体最大化

            // 获得所有端口列表并显示
            PortList.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                string str = ports[i].ToUpper();
                Regex reg = new Regex("[^COM\\d]", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                str = reg.Replace(str, "");
                PortList.Items.Add(str);
            }
            if (ports.Length > 1)
                PortList.SelectedIndex = 1;
        }


        #region Bluetooth related codes

        //创建一个蓝牙串口
        SerialPort BluetoothConnection = new SerialPort();

        //选择蓝牙设备(打开串口/按钮)
        private void link_Click(object sender, EventArgs e)
        {

            SelectBluetoothDeviceDialog dialog = new SelectBluetoothDeviceDialog();
            //dialog.ShowRemembered = true;//显示已经记住的蓝牙设备
            dialog.ShowAuthenticated = true;//显示已经认证过的蓝牙设备
            dialog.ShowUnknown = true;//显示未知蓝牙设备
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                address = dialog.SelectedDevice.DeviceAddress;//获取选择的蓝牙地址
                if (!BluetoothConnection.IsOpen)
                {
                    BluetoothConnection = new SerialPort();
                    link.Enabled = false;
                    BluetoothConnection.PortName = PortList.SelectedItem.ToString();
                    BluetoothConnection.Open();
                    BluetoothConnection.BaudRate = 115200;//波特率
                    BluetoothConnection.ReadTimeout = 1000;
                    BluetoothConnection.DataReceived += new SerialDataReceivedEventHandler(BluetoothDataRecevied);
                    //这是个弹窗
                    MessageBox.Show("蓝牙连接成功！\n地址：" + address.ToString() + "\n设备名：" + dialog.SelectedDevice.DeviceName, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }


        //蓝牙接收数据并显示波形
        public void BluetoothDataRecevied(object ebj, SerialDataReceivedEventArgs e)
        {

            Thread.Sleep(1000);
            //int length = 1000;
            int length = BluetoothConnection.ReadByte();
            length += BluetoothConnection.ReadByte() * 256;
            //BluetoothReceviedData = DateTime.Now.ToLongDateString() + "\r\n";
            byte[] data = new byte[1013];
            BluetoothConnection.Read(data, 0, 1013);
            byte[] version = new byte[13];
            BluetoothConnection.Read(version, 0, 13);
            double[] avgnum = new double[1013];
            List<double> avglist = new List<double>();

            // BluetoothConnection.Read(avgnum, 0.13);

            //上电校验
            if (version[0] == 255 && version[1] == 255 && version[2] == 255)
            {
                string ver = System.Text.Encoding.Default.GetString(version);
                byte add1 = version[3];
                byte add2 = version[4];
                byte com = version[5];
                byte len1 = version[6];
                byte len2 = version[7];
                //string len = ver.Substring(6, 2);//长度
                byte type1 = version[8];
                byte type2 = version[9];
                //string type = ver.Substring(8, 2);//设备类型
                byte vers1 = version[10];
                byte vers2 = version[11];
                //string vers = ver.Substring(10, 2);//版本号
                byte crc8 = version[12];
                //接收数据存到buffer数组
                byte[] buffer = new byte[] { add1, add2, com, len1, len2, type1, type2, vers1, vers2 };
                byte crcnum = CRC8(buffer);
                byte[] sendVer = new byte[] { add1, add2, 4, len1, len2, type1, type2, vers1, vers2 };
                string time = DateTime.Now.ToString("yyyyMMddHHmmss");
                int year = Convert.ToInt32(time.Substring(2, 2));
                int mou = Convert.ToInt32(time.Substring(4, 2));
                int day = Convert.ToInt32(time.Substring(6, 2));
                int hour = Convert.ToInt32(time.Substring(8, 2));
                int minute = Convert.ToInt32(time.Substring(10, 2));
                int second = Convert.ToInt32(time.Substring(12, 2));
                byte[] sendTime = new byte[] { add1, add2, 8, 0, 7, 20, (byte)year, (byte)mou, (byte)day, (byte)hour, (byte)minute, (byte)second };
                byte sendVerCrc = CRC8(sendVer);
                byte sendTimeCrc = CRC8(sendTime);
                //校验CRC发送认证
                if (com != 0 && crc8 == crcnum)
                {
                    BluetoothSendVer(new byte[] { 255, 255, 255, add1, add2, 4, len1, len2, type1, type2, vers1, vers2, sendVerCrc });
                    //Thread.Sleep(1000);
                    BluetoothSendTime(new byte[] { 255, 255, 255, add1, add2, 8, 0, 7, 20, (byte)year, (byte)mou, (byte)day, (byte)hour, (byte)minute, (byte)second, sendTimeCrc });
                    waveform.Series[0].Points.Clear();
                    data = new byte[1013];
                    BluetoothConnection.Read(data, 0, 1013);
                }
                else
                {
                    MessageBox.Show("校验失败，请重新启动。。。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            /*else if (version[0] != 255 && version[1] != 255 && version[2] != 255)
            {
                MessageBox.Show("接收信息错误！\n请重新连接。。。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

            int j = 0;
            //显示波形
            for (int i = 0; i < 1013; i++)
            {
                if (i < 980 && data[i] == 255 && data[i + 1] == 255 && data[i + 2] == 255)
                {

                    if (data[i + 7] == 14)
                    {
                        int avg1 = data[i + 8];
                        int avg2 = data[i + 9];
                        int max1 = data[i + 10];
                        int max2 = data[i + 11];
                        int temp1 = data[i + 14];
                        int temp2 = data[i + 15];
                        int hum1 = data[i + 16];
                        int hum2 = data[i + 17];
                        double avg = avg1 + (double)avg2 / 10;//平均值...



                        //图标类型：线
                        //waveform.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        //// 线的颜色为蓝色            
                        //waveform.Series[0].Color = Color.Blue;
                        //waveform.Series[0].Points.AddY(avg);//一次画一个点
                        //waveform.ChartAreas[0].AxisY.Maximum = 260;// Y轴最大值
                        //waveform.ChartAreas[0].AxisX.Maximum = 1000;
                        //waveform.Legends[0].Enabled = false;// 隐藏图示(Series 标注)


                        //avgnum[i] = avg;


                        //显示最大值
                        this.labelMax.Text = max1.ToString() + "." + max2.ToString();
                        if (max1 < 90)
                        {
                            this.labelMax.ForeColor = Color.Green;
                        }
                        else
                        {
                            this.labelMax.ForeColor = Color.Red;
                            this.labelMax.Font = new Font("宋体", 16);
                        }
                        //显示平均值
                        this.labelAvg.Text = avg.ToString();
                        if (avg < 70)
                        {
                            this.labelAvg.ForeColor = Color.Green;
                        }
                        else
                        {
                            this.labelAvg.ForeColor = Color.Red;
                            this.labelAvg.Font = new Font("宋体", 16);
                        }
                        this.labelTemp.Text = temp1.ToString() + "." + temp2.ToString();//显示温度
                        this.labelHum.Text = hum1.ToString() + "." + hum2.ToString();//显示湿度

                    }
                    do
                    {
                        if (j >= avgnum.Length)
                            break;
                        if (avgnum[j] != 0)
                        {
                            avglist.Add(avgnum[j]);
                        }
                        if (avglist.Count > 1000)
                        {
                            avglist.RemoveAt(0);
                        }
                        j++;
                    } while (avglist.Count < 1013);
                    //图标类型：线
                    waveform.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    // 线的颜色为蓝色            
                    waveform.Series[0].Color = Color.Blue;

                    for (int n = 0; n < avglist.Count; n++)
                    {
                        //MessageBox.Show(avgnum[i].ToString());
                        waveform.Series[0].Points.AddY(avglist[i]);
                    }
                    waveform.ChartAreas[0].AxisY.Maximum = 260;// Y轴最大值
                    waveform.ChartAreas[0].AxisX.Maximum = 1000;
                    waveform.Legends[0].Enabled = false;// 隐藏图示(Series 标注)
                }

                //if (i<1000&&data[i] == 0 && data[i + 1] == 0 && data[i + 2] == 0 && data[i + 3] == 0 && data[i + 4] == 0 || i == 900)
                //{
                //    waveform.Series[0].Points.Clear();
                //    // i = 0;
                //    data = new byte[1013];
                //    BluetoothConnection.Read(data, 0, 1013);
                //}
            }
        }
        #endregion

        // 断开串口按钮
        // C#串口不可用
        // 断开需关闭程序后重新启动
        public void disconnect_Click(object sender, EventArgs e)
        {
            BluetoothConnection.Close();
            BluetoothConnection.Dispose();
            BluetoothConnection = null;
            GC.Collect();
            link.Enabled = true;//断开后重置连接按钮
            MessageBox.Show("蓝牙已断开！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // 校验版本号
        private void BluetoothSendVer(byte[] data)
        {
            BluetoothConnection.Write(data, 0, 13);// 13表示发送字节数
        }

        // 发送校时命令
        private void BluetoothSendTime(byte[] data)
        {
            BluetoothConnection.Write(data, 0, 16);
        }


        //定位按钮
        public void position_Click(object sender, EventArgs e)
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.TryStart(false, TimeSpan.FromMilliseconds(5000));
            GeoCoordinate coordinate = watcher.Position.Location;
            if (coordinate.IsUnknown != true)
            {
                this.labelLong.Text = coordinate.Longitude.ToString();
                this.labelLat.Text = coordinate.Latitude.ToString();
            }
            else
            {
                MessageBox.Show("未检测到位置，请稍后重新定位");
            }
            //my.PortName = comboBox1.SelectedItem.ToString(); //设置端口号
            //my.BaudRate = int.Parse(comboBox1.Text);
            //my.Open();
            //my.DataReceived += my_DataRecevied;
        }

        //接收定位数据
        public void my_DataRecevied(object sender, SerialDataReceivedEventArgs e)
        {
            gpstext = gpstext + my.ReadExisting();
            if (gpstext.EndsWith("\r\n"))
            {
                BeginInvoke(new EventHandler(Update_Data));//执行update_data函数
            }
        }

        //定位
        private void Update_Data(object sender, EventArgs e)
        {
            string[] info = gpstext.Split(',');
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i] == "$GPRMC")
                {
                    if (info[i + 2] == "V")
                    {
                        this.labelLong.Text = info[i + 2];
                    }
                    if (info[i + 2] == "A")
                    {
                        this.labelLat.Text = "未定位";
                    }
                }
            }
            gpstext = "";//清空
        }


        //保存按钮
        public void save_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            int length = BluetoothConnection.ReadByte();
            //int length = BluetoothConnection.ReadByte();
            //length += BluetoothConnection.ReadByte() * 256;
            MessageBox.Show(length.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BluetoothReceviedData = DateTime.Now.ToLongDateString() + "\r\n";
            int lennum = 100;
            byte[] content = new byte[lennum];
            if (content[0] == 255 && content[1] == 255 && content[2] == 255)
            {
                byte len1 = content[6];
                byte len2 = content[7];
                if (len1 + len2 != 14)
                {
                    int qian = len1 / 16;
                    int bai = len1 % 16;
                    int shi = len2 / 10;
                    int ge = len2 % 10;//124
                    if (len1 == 0)
                    {
                        lennum = len2;
                    }
                    else if (len1 > 0 && len1 <= 15)
                    {
                        lennum = len1 * 16 * 16 + shi * 16 + ge;
                    }
                    else if (len1 > 15)
                    {
                        lennum = qian * 16 * 16 * 16 + bai * 16 * 16 + shi * 16 + ge;
                    }
                }
            }
            
            byte[] data = new byte[lennum];
            BluetoothConnection.Read(data, 0, 1000);
            for (int i = 0; i < 1000; i++)
            {

            }
            double maxDB = Convert.ToDouble(labelMax.ToString());
            double avgDB = Convert.ToDouble(labelAvg.ToString());
            double temp = Convert.ToDouble(labelTemp.ToString());
            double hum = Convert.ToDouble(labelHum.ToString());
            if (labelLong.Text == "0" && labelLat.Text == "0")
            {
                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
                watcher.TryStart(false, TimeSpan.FromMilliseconds(5000));
                GeoCoordinate coordinate = watcher.Position.Location;
                if (coordinate.IsUnknown != true)
                {
                    this.labelLong.Text = coordinate.Longitude.ToString();
                    this.labelLat.Text = coordinate.Latitude.ToString();
                }
            }
            string config = ConfigurationManager.ConnectionStrings["udpc"].ConnectionString;
            SqlConnection conn = new SqlConnection(config);
            string sql = "inssert into [dbo].[Datas] (detectTime, frequency, temperature, humidity, longitude, latitude, maxDB, avgDB, datas) values (@detectTime, @frequency, @temperature, @humidity, @longitude, @latitude, @maxDB, @avgDB, @datas)";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Datas");
            System.Data.DataTable table = ds.Tables["Datas"];
        }


        /* public void Form1_Load(object sender,EventArgs e)
         {
             //从配置文件获取连接字符串
             //string connStr = ConfigurationManager.ConnectionStrings["udpc"].ConnectionString;
             //建立连接
             //SqlConnection conn = new SqlConnection(connStr);
             SqlConnection conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=udpc;User ID=sa; Password=123456");
             //创建适配器对象
             SqlDataAdapter adapter = new SqlDataAdapter("select * from Users", conn);
             //创建数据集
             DataSet ds = new DataSet();
             DataTable dt = new DataTable("Users");
             //使用适配器填充数据集
             adapter.Fill(dt);
             //设置 DataGridView 控件的数据源
             dataGridView.DataSource = dt;
             this.usersTableAdapter.Fill(this.udpcDataSet.Users);
         }**/


        //跳转窗体到 edit
        public void historical_Click(object sender, EventArgs e)
        {
            Edit form2 = new Edit();
            form2.Owner = this;
            this.Hide();
            form2.ShowDialog();
            Application.ExitThread();
        }


        //CRC8校验
        public static byte CRC8(byte[] buffer)//buffer存储十进制
        {
            byte crc = 0;
            for (int i = 0; i < buffer.Length; i++)
            {
                crc ^= buffer[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x01) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0x8c;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            return crc;
        }

    }
}
