using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hello
{
    partial class Index
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.link = new System.Windows.Forms.Button();
            this.historical = new System.Windows.Forms.Button();
            this.waveform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.max = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.avg = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelLong = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.hum = new System.Windows.Forms.Label();
            this.labelHum = new System.Windows.Forms.Label();
            this.selectPorts = new System.Windows.Forms.Label();
            this.groupReal = new System.Windows.Forms.GroupBox();
            this.position = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.waveform)).BeginInit();
            this.groupReal.SuspendLayout();
            this.SuspendLayout();
            // 
            // link
            // 
            this.link.Font = new System.Drawing.Font("宋体", 16F);
            this.link.Location = new System.Drawing.Point(230, 438);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(120, 35);
            this.link.TabIndex = 6;
            this.link.Text = "连接蓝牙";
            this.link.UseVisualStyleBackColor = true;
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // historical
            // 
            this.historical.Font = new System.Drawing.Font("宋体", 16F);
            this.historical.Location = new System.Drawing.Point(1057, 436);
            this.historical.Name = "historical";
            this.historical.Size = new System.Drawing.Size(120, 35);
            this.historical.TabIndex = 9;
            this.historical.Text = "历史数据";
            this.historical.UseVisualStyleBackColor = true;
            this.historical.Click += new System.EventHandler(this.historical_Click);
            // 
            // waveform
            // 
            this.waveform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.waveform.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.waveform.Legends.Add(legend1);
            this.waveform.Location = new System.Drawing.Point(8, 21);
            this.waveform.Name = "waveform";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.waveform.Series.Add(series1);
            this.waveform.Size = new System.Drawing.Size(1246, 300);
            this.waveform.TabIndex = 18;
            this.waveform.Text = "waveform";
            // 
            // PortList
            // 
            this.PortList.Font = new System.Drawing.Font("宋体", 16F);
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(133, 442);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(80, 29);
            this.PortList.TabIndex = 0;
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("宋体", 16F);
            this.max.Location = new System.Drawing.Point(188, 375);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(98, 22);
            this.max.TabIndex = 19;
            this.max.Text = "最大值：";
            // 
            // labelMax
            // 
            this.labelMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("宋体", 14F);
            this.labelMax.Location = new System.Drawing.Point(287, 375);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(59, 19);
            this.labelMax.TabIndex = 19;
            this.labelMax.Text = "000.0";
            // 
            // avg
            // 
            this.avg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avg.AutoSize = true;
            this.avg.Font = new System.Drawing.Font("宋体", 16F);
            this.avg.Location = new System.Drawing.Point(7, 375);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(98, 22);
            this.avg.TabIndex = 19;
            this.avg.Text = "平均值：";
            // 
            // labelAvg
            // 
            this.labelAvg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvg.AutoSize = true;
            this.labelAvg.Font = new System.Drawing.Font("宋体", 14F);
            this.labelAvg.Location = new System.Drawing.Point(105, 375);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(59, 19);
            this.labelAvg.TabIndex = 20;
            this.labelAvg.Text = "000.0";
            // 
            // labelLong
            // 
            this.labelLong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLong.AutoSize = true;
            this.labelLong.Font = new System.Drawing.Font("宋体", 16F);
            this.labelLong.Location = new System.Drawing.Point(1117, 375);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(21, 22);
            this.labelLong.TabIndex = 19;
            this.labelLong.Text = "0";
            // 
            // latitude
            // 
            this.latitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latitude.AutoSize = true;
            this.latitude.Font = new System.Drawing.Font("宋体", 16F);
            this.latitude.Location = new System.Drawing.Point(820, 375);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(76, 22);
            this.latitude.TabIndex = 21;
            this.latitude.Text = "经度：";
            // 
            // labelLat
            // 
            this.labelLat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLat.AutoSize = true;
            this.labelLat.Font = new System.Drawing.Font("宋体", 16F);
            this.labelLat.Location = new System.Drawing.Point(902, 375);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(21, 22);
            this.labelLat.TabIndex = 19;
            this.labelLat.Text = "0";
            // 
            // longitude
            // 
            this.longitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.longitude.AutoSize = true;
            this.longitude.Font = new System.Drawing.Font("宋体", 16F);
            this.longitude.Location = new System.Drawing.Point(1035, 375);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(76, 22);
            this.longitude.TabIndex = 21;
            this.longitude.Text = "纬度：";
            // 
            // temp
            // 
            this.temp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("宋体", 16F);
            this.temp.Location = new System.Drawing.Point(390, 375);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(120, 22);
            this.temp.TabIndex = 19;
            this.temp.Text = "温度(℃)：";
            // 
            // labelTemp
            // 
            this.labelTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("宋体", 16F);
            this.labelTemp.Location = new System.Drawing.Point(516, 375);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(54, 22);
            this.labelTemp.TabIndex = 21;
            this.labelTemp.Text = "00.0";
            // 
            // hum
            // 
            this.hum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hum.AutoSize = true;
            this.hum.Font = new System.Drawing.Font("宋体", 16F);
            this.hum.Location = new System.Drawing.Point(597, 375);
            this.hum.Name = "hum";
            this.hum.Size = new System.Drawing.Size(109, 22);
            this.hum.TabIndex = 19;
            this.hum.Text = "湿度(%)：";
            // 
            // labelHum
            // 
            this.labelHum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHum.AutoSize = true;
            this.labelHum.Font = new System.Drawing.Font("宋体", 16F);
            this.labelHum.Location = new System.Drawing.Point(712, 375);
            this.labelHum.Name = "labelHum";
            this.labelHum.Size = new System.Drawing.Size(54, 22);
            this.labelHum.TabIndex = 21;
            this.labelHum.Text = "00.0";
            // 
            // selectPorts
            // 
            this.selectPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPorts.AutoSize = true;
            this.selectPorts.Font = new System.Drawing.Font("宋体", 16F);
            this.selectPorts.Location = new System.Drawing.Point(7, 445);
            this.selectPorts.Name = "selectPorts";
            this.selectPorts.Size = new System.Drawing.Size(120, 22);
            this.selectPorts.TabIndex = 21;
            this.selectPorts.Text = "选择端口：";
            // 
            // groupReal
            // 
            this.groupReal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupReal.Controls.Add(this.waveform);
            this.groupReal.Font = new System.Drawing.Font("宋体", 12F);
            this.groupReal.Location = new System.Drawing.Point(2, 12);
            this.groupReal.Name = "groupReal";
            this.groupReal.Size = new System.Drawing.Size(1260, 330);
            this.groupReal.TabIndex = 22;
            this.groupReal.TabStop = false;
            this.groupReal.Text = "实时波形";
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("宋体", 16F);
            this.position.Location = new System.Drawing.Point(632, 438);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(120, 35);
            this.position.TabIndex = 23;
            this.position.Text = "定位";
            this.position.UseVisualStyleBackColor = true;
            this.position.Click += new System.EventHandler(this.position_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("宋体", 16F);
            this.save.Location = new System.Drawing.Point(917, 436);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 35);
            this.save.TabIndex = 24;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(520, 444);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 29);
            this.comboBox1.TabIndex = 25;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.position);
            this.Controls.Add(this.groupReal);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.max);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.labelLong);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.hum);
            this.Controls.Add(this.labelHum);
            this.Controls.Add(this.selectPorts);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.link);
            this.Controls.Add(this.historical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "局放检测";
            ((System.ComponentModel.ISupportInitialize)(this.waveform)).EndInit();
            this.groupReal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void labelReal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion
        private GroupBox groupReal;
        private Chart waveform;

        private Label max;
        private Label labelMax;
        private Label avg;
        private Label labelAvg;
        private Label longitude;//纬度
        private Label labelLong;
        private Label latitude;//经度
        private Label labelLat;
        private Label temp;
        private Label labelTemp;
        private Label hum;
        private Label labelHum;

        private Label selectPorts;
        private ComboBox PortList;
        private Button link;
        //private Button disconnect;
        private Button position;
        private Button save;
        private Button historical;
        private ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

