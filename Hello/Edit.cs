using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Office.Interop.Word;

namespace Hello
{
    public partial class Edit : Form
    {

        private SQLiteConnection conn = new SQLiteConnection("Data Source=" + System.Windows.Forms.Application.StartupPath + @"\test.db");
        private SQLiteDataAdapter da = null;
        DataSet ds = new DataSet();


        public Edit()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;// 显示任务栏
            this.WindowState = FormWindowState.Maximized;// 窗体最大化
            txtID.ReadOnly = true;
            if (txtID.Text.Length == 0)
            {
                updateNum.Enabled = false;
                updateOverall.Enabled = false;
                updatePartial.Enabled = false;
            }
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void RefreshData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter("select * from Datas;", conn);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }


        //加载
        public void Edit_Load(object sender, EventArgs e)
        {
            RefreshData();
            dataGridView1.Columns[0].HeaderCell.Value = "编号";
            dataGridView1.Columns[1].HeaderCell.Value = "检测时间";
            dataGridView1.Columns[2].HeaderCell.Value = "检测员";
            dataGridView1.Columns[3].HeaderCell.Value = "线路名称";
            dataGridView1.Columns[4].HeaderCell.Value = "杆塔编号";
            dataGridView1.Columns[5].HeaderCell.Value = "设备类型";
            dataGridView1.Columns[6].HeaderCell.Value = "设备状态";
            dataGridView1.Columns[7].HeaderCell.Value = "频率";
            dataGridView1.Columns[8].HeaderCell.Value = "距离(m)";
            dataGridView1.Columns[9].HeaderCell.Value = "温度";
            dataGridView1.Columns[10].HeaderCell.Value = "湿度(%)";
            dataGridView1.Columns[11].HeaderCell.Value = "经度";
            dataGridView1.Columns[12].HeaderCell.Value = "纬度";
            dataGridView1.Columns[13].HeaderCell.Value = "最大值";
            dataGridView1.Columns[14].HeaderCell.Value = "平均值";
            dataGridView1.Columns[15].HeaderCell.Value = "杆塔编号照片";
            dataGridView1.Columns[16].HeaderCell.Value = "整体全景照片";
            dataGridView1.Columns[17].HeaderCell.Value = "缺陷局部照片";
            dataGridView1.Columns[18].HeaderCell.Value = "缺陷程度";
            dataGridView1.Columns[19].HeaderCell.Value = "数据";
            dataGridView1.Columns[20].HeaderCell.Value = "音频文件";
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;



            comboBox1.Text = "柱式绝缘子";
            comboBox2.SelectedIndex = 4;
        }


        //选中某行
        public void dataView_Click(object sender,EventArgs e)
        {
            DataGridViewRow selectRow = dataGridView1.SelectedRows[0];
            //dateTimePicker1.Value = System.Convert.ToDateTime(selectRow.Cells[1].Value.ToString());
            txtID.Text = Convert.ToString(selectRow.Cells[0].Value.ToString());
            txtInspector.Text = System.Convert.ToString(selectRow.Cells[2].Value.ToString());
            txtLineName.Text = System.Convert.ToString(selectRow.Cells[3].Value.ToString());
            txtTowerNum.Text = System.Convert.ToString(selectRow.Cells[4].Value.ToString());
            txtFrequency.Text = System.Convert.ToString(selectRow.Cells[7].Value.ToString());
            txtDistance.Text = System.Convert.ToString(selectRow.Cells[8].Value.ToString());
            txtTemp.Text = System.Convert.ToString(selectRow.Cells[9].Value.ToString());
            txtHum.Text = System.Convert.ToString(selectRow.Cells[10].Value.ToString());
            txtLongitude.Text = System.Convert.ToString(selectRow.Cells[11].Value.ToString());
            txtLatitude.Text = System.Convert.ToString(selectRow.Cells[12].Value.ToString());
            txtMax.Text = System.Convert.ToString(selectRow.Cells[13].Value.ToString());
            txtAvg.Text = System.Convert.ToString(selectRow.Cells[14].Value.ToString());
            txtDefect.Text = System.Convert.ToString(selectRow.Cells[18].Value.ToString());
            txtNumPic.Text = System.Convert.ToString(selectRow.Cells[15].Value.ToString());
            txtPartialPic.Text = System.Convert.ToString(selectRow.Cells[16].Value.ToString());
            txtOverallPic.Text = System.Convert.ToString(selectRow.Cells[17].Value.ToString());

            if (txtID.Text.Length != 0)
            {
                updateNum.Enabled = true;
                updateOverall.Enabled = true;
                updatePartial.Enabled = true;
            }
        }


        //跳转主页
        public void home_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Owner = this;
            this.Hide();
            index.ShowDialog();
        }


        //删除
        private void delete_Click(object sender,EventArgs e)
        {
            if (MessageBox.Show("确定要删除此行信息吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
            }
        }


        //重置（取消）
        public void cancel_Click(object sender,EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            txtInspector.Text = "";
            txtLineName.Text = "";
            txtTowerNum.Text = "";
            txtFrequency.Text = "";
            txtDistance.Text = "";
            txtTemp.Text = "";
            txtHum.Text = "";
            txtLongitude.Text = "";
            txtLatitude.Text = "";
            txtMax.Text = "";
            txtAvg.Text = "";
            txtDefect.Text = "";
            txtNumPic.Text = "";
            txtPartialPic.Text = "";
            txtOverallPic.Text = "";
        }


        //修改保存
        private void save_Click(object sender,EventArgs e)
        {
            object sid = dataGridView1.SelectedRows[0].Cells[0].Value;
            conn.Open();
            string sql = "update Datas set inspector = '" + txtInspector.Text + "', lineName = '" + txtLineName.Text + "', towerNum = '" + txtTowerNum.Text + "', deviceState = '" + comboBox2.Text + "',deviceType = '" + comboBox1.Text + "', frequency = '" + txtFrequency.Text + "', distance = '" + txtDistance.Text + "', temperature = '" + txtTemp.Text + "', humidity = '" + txtHum.Text + "', longitude = '" + txtLongitude.Text + "', latitude = '" + txtLatitude.Text + "', maxDB = '" + txtMax.Text + "', avgDB = '" + txtAvg.Text + "', defect = '" + txtDefect.Text + "'" + " where id = " + sid;
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("修改成功！");
            RefreshData();
            conn.Close();
            
        }


        /// <summary>
        /// 将字符串存储为word文档格式的文件的方法(多线程)。
        /// </summary>
        /// <param name="strText">要保存的字符串内容。</param>
        /// 需要标签
        public void print_Click(object p_str,EventArgs e)
        {
            object sid = dataGridView1.SelectedRows[0].Cells[0].Value;
            string config = "Data Source=" + System.Windows.Forms.Application.StartupPath + @"\test.db";
            SQLiteConnection conn = new SQLiteConnection(config);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Datas where id = " + sid;
            SQLiteDataReader reader = null;
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word._Application word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = false;

            //Application.StartupPath -- 获取到 .exe 所在 debug 路径
            object template = System.Windows.Forms.Application.StartupPath+@"\template\template.dotx";

            object linkToFile = false;// 定义该插入图片是否为外部链接
            object saveWithDocument = true;// 定义插入图片是否随 word 文档一起保存
            string numName = "编号" +sid+ ".png";
            string replaceNumPic = System.Windows.Forms.Application.StartupPath + @"\images\" + numName;
            string overallName =  "整体" +sid+ ".png";
            string replaceOverallPic = System.Windows.Forms.Application.StartupPath + @"\images\" + overallName;
            string partialName = "缺陷" +sid+ ".png";
            string replacePartialPic = System.Windows.Forms.Application.StartupPath + @"\images\" + partialName;

            Microsoft.Office.Interop.Word._Document docx = word.Documents.Add(ref template, ref missing, ref missing, ref missing);
            object[] bookmarks = new object[17];
            bookmarks[0] = "time";
            bookmarks[1] = "detectTime";
            bookmarks[2] = "inspector";
            bookmarks[3] = "lineName";
            bookmarks[4] = "towerNum";
            bookmarks[5] = "deviceType";
            bookmarks[6] = "deviceState";
            bookmarks[7] = "distance";
            bookmarks[8] = "temperature";
            bookmarks[9] = "humidity";
            bookmarks[10] = "longtitude";
            bookmarks[11] = "latitude";
            bookmarks[12] = "maxDB";
            bookmarks[13] = "avgDB";
            bookmarks[14] = "numPic";
            bookmarks[15] = "overallPic";
            bookmarks[16] = "partialPic";
            docx.Bookmarks.get_Item(ref bookmarks[0]).Range.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (reader.Read())
            {
                docx.Bookmarks.get_Item(ref bookmarks[1]).Range.Text = reader["detectTime"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[2]).Range.Text = reader["inspector"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[3]).Range.Text = reader["lineName"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[4]).Range.Text = reader["towerNum"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[5]).Range.Text = reader["deviceType"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[6]).Range.Text = reader["deviceState"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[7]).Range.Text = reader["distance"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[8]).Range.Text = reader["temperature"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[9]).Range.Text = reader["humidity"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[10]).Range.Text = reader["longtitude"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[11]).Range.Text = reader["latitude"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[12]).Range.Text = reader["maxDB"].ToString();
                docx.Bookmarks.get_Item(ref bookmarks[13]).Range.Text = reader["avgDB"].ToString();
                //docx.Bookmarks.get_Item(ref bookmarks[14]).Range.Text = reader["numPic"].ToString();
                //docx.Bookmarks.get_Item(ref bookmarks[15]).Range.Text = reader["overallPic"].ToString();
                //docx.Bookmarks.get_Item(ref bookmarks[16]).Range.Text = reader["partialPic"].ToString();

                object numPicMark = bookmarks[14].ToString();// 杆塔编号照片书签
                docx.Bookmarks.get_Item(ref numPicMark).Select();// 查找图片书签
                word.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;// 设置图片居中
                InlineShape numShape = word.Selection.InlineShapes.AddPicture(replaceNumPic, ref linkToFile, ref saveWithDocument, ref missing);// 在书签位置添加图片
                numShape.Height = 240;
                numShape.Width = 240;
                object overallPicMark = bookmarks[15].ToString();// 整体照片书签
                docx.Bookmarks.get_Item(ref numPicMark).Select();// 查找图片书签
                word.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;// 设置图片居中
                InlineShape overallShape = word.Selection.InlineShapes.AddPicture(replaceOverallPic, ref linkToFile, ref saveWithDocument, ref missing);// 在书签位置添加图片
                overallShape.Height = 240;
                overallShape.Width = 240;
                object partialPicMark = bookmarks[16].ToString();// 杆塔编号照片书签
                docx.Bookmarks.get_Item(ref numPicMark).Select();// 查找图片书签
                word.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;// 设置图片居中
                InlineShape partialShape = word.Selection.InlineShapes.AddPicture(replacePartialPic, ref linkToFile, ref saveWithDocument, ref missing);// 在书签位置添加图片
                partialShape.Height = 240;
                partialShape.Width = 240;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName= DateTime.Now.ToString("yyyyMMddHHmmss");
            sfd.Filter = "Word 文档(*.docx)|*.docx|Word 97-2003 文档(*.doc)|(*.doc)";
            sfd.DefaultExt= "Word 文档(*.docx)|*.docx|Word 97-2003 文档(*.doc)|(*.doc)";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                object filename = sfd.FileName;
                docx.SaveAs2(ref filename, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                docx.Close(ref missing, ref missing, ref missing);
                word.Quit(ref missing, ref missing, ref missing);
                MessageBox.Show("已生成报告");
            }
            reader.Close();
            conn.Close();

        }

        private void updateNum_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                object sid = dataGridView1.SelectedRows[0].Cells[0].Value;
                string fileName = openFileDialog1.FileName;
                string fileRename = "编号" +sid+ Path.GetExtension(openFileDialog1.FileName);
                string localPath = System.Windows.Forms.Application.StartupPath + @"\images\" + fileRename;
                File.Copy(fileName, localPath);
                this.txtNumPic.Text = localPath;

                
                string config = "Data Source=" + System.Windows.Forms.Application.StartupPath + @"\test.db";
                SQLiteConnection conn = new SQLiteConnection(config);
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("update Datas set numPic = @numPic where id = @id", conn);
                cmd.Parameters.Add(new SQLiteParameter("@numPic", localPath));
                cmd.Parameters.Add(new SQLiteParameter("@id", sid));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("上传成功！");
                }
                else
                {
                    MessageBox.Show("上传失败。。。请重新选择");
                }
                conn.Close();
            }
        }

        private void updateOverall_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                object sid = dataGridView1.SelectedRows[0].Cells[0].Value;
                string fileName = openFileDialog1.FileName;
                string fileRename =  "整体" +sid+ Path.GetExtension(openFileDialog1.FileName);
                string localPath = System.Windows.Forms.Application.StartupPath + @"\images\" + fileRename;
                File.Copy(fileName, localPath);
                this.txtNumPic.Text = localPath;

                
                string config = "Data Source=" + System.Windows.Forms.Application.StartupPath + @"\test.db";
                SQLiteConnection conn = new SQLiteConnection(config);
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("update Datas set overallPic = @overallPic where id = @id", conn);
                cmd.Parameters.Add(new SQLiteParameter("@overallPic", localPath));
                cmd.Parameters.Add(new SQLiteParameter("@id", sid));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("上传成功！");
                }
                else
                {
                    MessageBox.Show("上传失败。。。请重新选择");
                }
                conn.Close();
            }
        }

        private void updatePartial_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                object sid = dataGridView1.SelectedRows[0].Cells[0].Value;
                string fileName = openFileDialog1.FileName;
                string fileRename =  "缺陷" +sid+ Path.GetExtension(openFileDialog1.FileName);
                string localPath = System.Windows.Forms.Application.StartupPath + @"\images\" + fileRename;
                File.Copy(fileName, localPath);
                this.txtNumPic.Text = localPath;

                string config = "Data Source=" + System.Windows.Forms.Application.StartupPath + @"\test.db";
                SQLiteConnection conn = new SQLiteConnection(config);
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("update Datas set partialPic = @partialPic where id = @id", conn);
                cmd.Parameters.Add(new SQLiteParameter("@partialPic", localPath));
                cmd.Parameters.Add(new SQLiteParameter("@id", sid));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("上传成功！");
                }
                else
                {
                    MessageBox.Show("上传失败。。。请重新选择");
                }
                conn.Close();
            }
        }
    }
}
