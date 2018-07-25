using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hello
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.dataTable = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detectTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.towerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgDBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallPicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialPicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.udpcDataSet1 = new Hello.udpcDataSet1();
            this.detailEdit = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtPartialPic = new System.Windows.Forms.TextBox();
            this.updatePartial = new System.Windows.Forms.Button();
            this.txtOverallPic = new System.Windows.Forms.TextBox();
            this.updateOverall = new System.Windows.Forms.Button();
            this.updateNum = new System.Windows.Forms.Button();
            this.txtNumPic = new System.Windows.Forms.TextBox();
            this.txtDefect = new System.Windows.Forms.TextBox();
            this.labelDefect = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.labelAvg = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.txtHum = new System.Windows.Forms.TextBox();
            this.labelHum = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.txtTowerNum = new System.Windows.Forms.TextBox();
            this.labelTowerNum = new System.Windows.Forms.Label();
            this.txtLineName = new System.Windows.Forms.TextBox();
            this.labelLineName = new System.Windows.Forms.Label();
            this.txtInspector = new System.Windows.Forms.TextBox();
            this.labelInspector = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.datasTableAdapter = new Hello.udpcDataSet1TableAdapters.DatasTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udpcDataSet1)).BeginInit();
            this.detailEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTable.Controls.Add(this.dataGridView1);
            this.dataTable.Font = new System.Drawing.Font("宋体", 12F);
            this.dataTable.Location = new System.Drawing.Point(12, 12);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(1176, 210);
            this.dataTable.TabIndex = 0;
            this.dataTable.TabStop = false;
            this.dataTable.Text = "数据列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIdDataGridViewTextBoxColumn,
            this.detectTimeDataGridViewTextBoxColumn,
            this.inspectorDataGridViewTextBoxColumn,
            this.lineNameDataGridViewTextBoxColumn,
            this.towerNumDataGridViewTextBoxColumn,
            this.deviceTypeDataGridViewTextBoxColumn,
            this.deviceStateDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.maxDBDataGridViewTextBoxColumn,
            this.avgDBDataGridViewTextBoxColumn,
            this.numPicDataGridViewTextBoxColumn,
            this.overallPicDataGridViewTextBoxColumn,
            this.partialPicDataGridViewTextBoxColumn,
            this.defectDataGridViewTextBoxColumn,
            this.datasDataGridViewTextBoxColumn,
            this.audioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datasBindingSource;
            this.dataGridView1.Font = new System.Drawing.Font("宋体", 10F);
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataIdDataGridViewTextBoxColumn
            // 
            this.dataIdDataGridViewTextBoxColumn.DataPropertyName = "dataId";
            this.dataIdDataGridViewTextBoxColumn.HeaderText = "编号";
            this.dataIdDataGridViewTextBoxColumn.Name = "dataIdDataGridViewTextBoxColumn";
            this.dataIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detectTimeDataGridViewTextBoxColumn
            // 
            this.detectTimeDataGridViewTextBoxColumn.DataPropertyName = "detectTime";
            this.detectTimeDataGridViewTextBoxColumn.HeaderText = "检测时间";
            this.detectTimeDataGridViewTextBoxColumn.Name = "detectTimeDataGridViewTextBoxColumn";
            this.detectTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectorDataGridViewTextBoxColumn
            // 
            this.inspectorDataGridViewTextBoxColumn.DataPropertyName = "inspector";
            this.inspectorDataGridViewTextBoxColumn.HeaderText = "检测员";
            this.inspectorDataGridViewTextBoxColumn.Name = "inspectorDataGridViewTextBoxColumn";
            this.inspectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineNameDataGridViewTextBoxColumn
            // 
            this.lineNameDataGridViewTextBoxColumn.DataPropertyName = "lineName";
            this.lineNameDataGridViewTextBoxColumn.HeaderText = "线路名称";
            this.lineNameDataGridViewTextBoxColumn.Name = "lineNameDataGridViewTextBoxColumn";
            this.lineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // towerNumDataGridViewTextBoxColumn
            // 
            this.towerNumDataGridViewTextBoxColumn.DataPropertyName = "towerNum";
            this.towerNumDataGridViewTextBoxColumn.HeaderText = "杆塔编号";
            this.towerNumDataGridViewTextBoxColumn.Name = "towerNumDataGridViewTextBoxColumn";
            this.towerNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceTypeDataGridViewTextBoxColumn
            // 
            this.deviceTypeDataGridViewTextBoxColumn.DataPropertyName = "deviceType";
            this.deviceTypeDataGridViewTextBoxColumn.HeaderText = "设备类型";
            this.deviceTypeDataGridViewTextBoxColumn.Name = "deviceTypeDataGridViewTextBoxColumn";
            this.deviceTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceStateDataGridViewTextBoxColumn
            // 
            this.deviceStateDataGridViewTextBoxColumn.DataPropertyName = "deviceState";
            this.deviceStateDataGridViewTextBoxColumn.HeaderText = "设备状态";
            this.deviceStateDataGridViewTextBoxColumn.Name = "deviceStateDataGridViewTextBoxColumn";
            this.deviceStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "频率";
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            this.frequencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "检测距离";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "温度";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "湿度";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            this.humidityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "经度";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            this.longitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "纬度";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            this.latitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxDBDataGridViewTextBoxColumn
            // 
            this.maxDBDataGridViewTextBoxColumn.DataPropertyName = "maxDB";
            this.maxDBDataGridViewTextBoxColumn.HeaderText = "最大值";
            this.maxDBDataGridViewTextBoxColumn.Name = "maxDBDataGridViewTextBoxColumn";
            this.maxDBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avgDBDataGridViewTextBoxColumn
            // 
            this.avgDBDataGridViewTextBoxColumn.DataPropertyName = "avgDB";
            this.avgDBDataGridViewTextBoxColumn.HeaderText = "平均值";
            this.avgDBDataGridViewTextBoxColumn.Name = "avgDBDataGridViewTextBoxColumn";
            this.avgDBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numPicDataGridViewTextBoxColumn
            // 
            this.numPicDataGridViewTextBoxColumn.DataPropertyName = "numPic";
            this.numPicDataGridViewTextBoxColumn.HeaderText = "杆塔编号照片";
            this.numPicDataGridViewTextBoxColumn.Name = "numPicDataGridViewTextBoxColumn";
            this.numPicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overallPicDataGridViewTextBoxColumn
            // 
            this.overallPicDataGridViewTextBoxColumn.DataPropertyName = "overallPic";
            this.overallPicDataGridViewTextBoxColumn.HeaderText = "杆塔全景照片";
            this.overallPicDataGridViewTextBoxColumn.Name = "overallPicDataGridViewTextBoxColumn";
            this.overallPicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partialPicDataGridViewTextBoxColumn
            // 
            this.partialPicDataGridViewTextBoxColumn.DataPropertyName = "partialPic";
            this.partialPicDataGridViewTextBoxColumn.HeaderText = "缺陷局部照片";
            this.partialPicDataGridViewTextBoxColumn.Name = "partialPicDataGridViewTextBoxColumn";
            this.partialPicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defectDataGridViewTextBoxColumn
            // 
            this.defectDataGridViewTextBoxColumn.DataPropertyName = "defect";
            this.defectDataGridViewTextBoxColumn.HeaderText = "缺陷程度";
            this.defectDataGridViewTextBoxColumn.Name = "defectDataGridViewTextBoxColumn";
            this.defectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datasDataGridViewTextBoxColumn
            // 
            this.datasDataGridViewTextBoxColumn.DataPropertyName = "datas";
            this.datasDataGridViewTextBoxColumn.HeaderText = "数据";
            this.datasDataGridViewTextBoxColumn.Name = "datasDataGridViewTextBoxColumn";
            this.datasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // audioDataGridViewTextBoxColumn
            // 
            this.audioDataGridViewTextBoxColumn.DataPropertyName = "audio";
            this.audioDataGridViewTextBoxColumn.HeaderText = "音频";
            this.audioDataGridViewTextBoxColumn.Name = "audioDataGridViewTextBoxColumn";
            this.audioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datasBindingSource
            // 
            this.datasBindingSource.DataMember = "Datas";
            this.datasBindingSource.DataSource = this.udpcDataSet1;
            // 
            // udpcDataSet1
            // 
            this.udpcDataSet1.DataSetName = "udpcDataSet1";
            this.udpcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailEdit
            // 
            this.detailEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailEdit.Controls.Add(this.chart1);
            this.detailEdit.Controls.Add(this.txtPartialPic);
            this.detailEdit.Controls.Add(this.updatePartial);
            this.detailEdit.Controls.Add(this.txtOverallPic);
            this.detailEdit.Controls.Add(this.updateOverall);
            this.detailEdit.Controls.Add(this.updateNum);
            this.detailEdit.Controls.Add(this.txtNumPic);
            this.detailEdit.Controls.Add(this.txtDefect);
            this.detailEdit.Controls.Add(this.labelDefect);
            this.detailEdit.Controls.Add(this.txtAvg);
            this.detailEdit.Controls.Add(this.labelAvg);
            this.detailEdit.Controls.Add(this.txtMax);
            this.detailEdit.Controls.Add(this.labelMax);
            this.detailEdit.Controls.Add(this.txtLatitude);
            this.detailEdit.Controls.Add(this.labelLatitude);
            this.detailEdit.Controls.Add(this.txtLongitude);
            this.detailEdit.Controls.Add(this.labelLongitude);
            this.detailEdit.Controls.Add(this.txtHum);
            this.detailEdit.Controls.Add(this.labelHum);
            this.detailEdit.Controls.Add(this.txtTemp);
            this.detailEdit.Controls.Add(this.labelTemp);
            this.detailEdit.Controls.Add(this.txtDistance);
            this.detailEdit.Controls.Add(this.labelDistance);
            this.detailEdit.Controls.Add(this.txtFrequency);
            this.detailEdit.Controls.Add(this.labelFrequency);
            this.detailEdit.Controls.Add(this.comboBox2);
            this.detailEdit.Controls.Add(this.label6);
            this.detailEdit.Controls.Add(this.comboBox1);
            this.detailEdit.Controls.Add(this.labelType);
            this.detailEdit.Controls.Add(this.txtTowerNum);
            this.detailEdit.Controls.Add(this.labelTowerNum);
            this.detailEdit.Controls.Add(this.txtLineName);
            this.detailEdit.Controls.Add(this.labelLineName);
            this.detailEdit.Controls.Add(this.txtInspector);
            this.detailEdit.Controls.Add(this.labelInspector);
            this.detailEdit.Controls.Add(this.dateTimePicker1);
            this.detailEdit.Controls.Add(this.labelTime);
            this.detailEdit.Font = new System.Drawing.Font("宋体", 12F);
            this.detailEdit.Location = new System.Drawing.Point(12, 228);
            this.detailEdit.Name = "detailEdit";
            this.detailEdit.Size = new System.Drawing.Size(1176, 400);
            this.detailEdit.TabIndex = 1;
            this.detailEdit.TabStop = false;
            this.detailEdit.Text = "详情编辑";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 170);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1164, 224);
            this.chart1.TabIndex = 41;
            this.chart1.Text = "chart1";
            // 
            // txtPartialPic
            // 
            this.txtPartialPic.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPartialPic.Location = new System.Drawing.Point(887, 140);
            this.txtPartialPic.Name = "txtPartialPic";
            this.txtPartialPic.Size = new System.Drawing.Size(150, 26);
            this.txtPartialPic.TabIndex = 40;
            // 
            // updatePartial
            // 
            this.updatePartial.Font = new System.Drawing.Font("宋体", 12F);
            this.updatePartial.Location = new System.Drawing.Point(726, 140);
            this.updatePartial.Name = "updatePartial";
            this.updatePartial.Size = new System.Drawing.Size(150, 26);
            this.updatePartial.TabIndex = 39;
            this.updatePartial.Text = "上传缺陷局部照片";
            this.updatePartial.UseVisualStyleBackColor = true;
            this.updatePartial.Click += new System.EventHandler(this.updatePartial_Click);
            // 
            // txtOverallPic
            // 
            this.txtOverallPic.Font = new System.Drawing.Font("宋体", 12F);
            this.txtOverallPic.Location = new System.Drawing.Point(535, 140);
            this.txtOverallPic.Name = "txtOverallPic";
            this.txtOverallPic.Size = new System.Drawing.Size(150, 26);
            this.txtOverallPic.TabIndex = 38;
            // 
            // updateOverall
            // 
            this.updateOverall.Font = new System.Drawing.Font("宋体", 12F);
            this.updateOverall.Location = new System.Drawing.Point(379, 138);
            this.updateOverall.Name = "updateOverall";
            this.updateOverall.Size = new System.Drawing.Size(150, 26);
            this.updateOverall.TabIndex = 37;
            this.updateOverall.Text = "上传杆塔全景照片";
            this.updateOverall.UseVisualStyleBackColor = true;
            this.updateOverall.Click += new System.EventHandler(this.updateOverall_Click);
            // 
            // updateNum
            // 
            this.updateNum.Font = new System.Drawing.Font("宋体", 12F);
            this.updateNum.Location = new System.Drawing.Point(28, 138);
            this.updateNum.Name = "updateNum";
            this.updateNum.Size = new System.Drawing.Size(150, 26);
            this.updateNum.TabIndex = 36;
            this.updateNum.Text = "上传杆塔编号照片";
            this.updateNum.UseVisualStyleBackColor = true;
            this.updateNum.Click += new System.EventHandler(this.updateNum_Click);
            // 
            // txtNumPic
            // 
            this.txtNumPic.Font = new System.Drawing.Font("宋体", 12F);
            this.txtNumPic.Location = new System.Drawing.Point(184, 138);
            this.txtNumPic.Name = "txtNumPic";
            this.txtNumPic.Size = new System.Drawing.Size(150, 26);
            this.txtNumPic.TabIndex = 33;
            // 
            // txtDefect
            // 
            this.txtDefect.Font = new System.Drawing.Font("宋体", 12F);
            this.txtDefect.Location = new System.Drawing.Point(908, 98);
            this.txtDefect.Name = "txtDefect";
            this.txtDefect.Size = new System.Drawing.Size(100, 26);
            this.txtDefect.TabIndex = 31;
            // 
            // labelDefect
            // 
            this.labelDefect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDefect.AutoSize = true;
            this.labelDefect.Font = new System.Drawing.Font("宋体", 12F);
            this.labelDefect.Location = new System.Drawing.Point(830, 101);
            this.labelDefect.Name = "labelDefect";
            this.labelDefect.Size = new System.Drawing.Size(72, 16);
            this.labelDefect.TabIndex = 30;
            this.labelDefect.Text = "缺陷程度";
            // 
            // txtAvg
            // 
            this.txtAvg.Font = new System.Drawing.Font("宋体", 12F);
            this.txtAvg.Location = new System.Drawing.Point(689, 98);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(100, 26);
            this.txtAvg.TabIndex = 29;
            // 
            // labelAvg
            // 
            this.labelAvg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvg.AutoSize = true;
            this.labelAvg.Font = new System.Drawing.Font("宋体", 12F);
            this.labelAvg.Location = new System.Drawing.Point(619, 101);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(64, 16);
            this.labelAvg.TabIndex = 28;
            this.labelAvg.Text = "平均 DB";
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMax.Location = new System.Drawing.Point(481, 98);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 26);
            this.txtMax.TabIndex = 27;
            // 
            // labelMax
            // 
            this.labelMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("宋体", 12F);
            this.labelMax.Location = new System.Drawing.Point(411, 101);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(64, 16);
            this.labelMax.TabIndex = 26;
            this.labelMax.Text = "最大 DB";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("宋体", 12F);
            this.txtLatitude.Location = new System.Drawing.Point(264, 98);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(100, 26);
            this.txtLatitude.TabIndex = 25;
            // 
            // labelLatitude
            // 
            this.labelLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Font = new System.Drawing.Font("宋体", 12F);
            this.labelLatitude.Location = new System.Drawing.Point(218, 101);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(40, 16);
            this.labelLatitude.TabIndex = 24;
            this.labelLatitude.Text = "纬度";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Font = new System.Drawing.Font("宋体", 12F);
            this.txtLongitude.Location = new System.Drawing.Point(71, 98);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(100, 26);
            this.txtLongitude.TabIndex = 23;
            // 
            // labelLongitude
            // 
            this.labelLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Font = new System.Drawing.Font("宋体", 12F);
            this.labelLongitude.Location = new System.Drawing.Point(25, 101);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(40, 16);
            this.labelLongitude.TabIndex = 22;
            this.labelLongitude.Text = "经度";
            // 
            // txtHum
            // 
            this.txtHum.Font = new System.Drawing.Font("宋体", 12F);
            this.txtHum.Location = new System.Drawing.Point(998, 63);
            this.txtHum.Name = "txtHum";
            this.txtHum.Size = new System.Drawing.Size(100, 26);
            this.txtHum.TabIndex = 21;
            // 
            // labelHum
            // 
            this.labelHum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHum.AutoSize = true;
            this.labelHum.Font = new System.Drawing.Font("宋体", 12F);
            this.labelHum.Location = new System.Drawing.Point(928, 68);
            this.labelHum.Name = "labelHum";
            this.labelHum.Size = new System.Drawing.Size(64, 16);
            this.labelHum.TabIndex = 20;
            this.labelHum.Text = "湿度(%)";
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTemp.Location = new System.Drawing.Point(795, 63);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 26);
            this.txtTemp.TabIndex = 19;
            // 
            // labelTemp
            // 
            this.labelTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTemp.Location = new System.Drawing.Point(717, 68);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(72, 16);
            this.labelTemp.TabIndex = 18;
            this.labelTemp.Text = "温度(℃)";
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("宋体", 12F);
            this.txtDistance.Location = new System.Drawing.Point(587, 63);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 26);
            this.txtDistance.TabIndex = 17;
            // 
            // labelDistance
            // 
            this.labelDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("宋体", 12F);
            this.labelDistance.Location = new System.Drawing.Point(509, 68);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(72, 16);
            this.labelDistance.TabIndex = 16;
            this.labelDistance.Text = "检测距离";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Font = new System.Drawing.Font("宋体", 12F);
            this.txtFrequency.Location = new System.Drawing.Point(1053, 21);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(100, 26);
            this.txtFrequency.TabIndex = 15;
            // 
            // labelFrequency
            // 
            this.labelFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("宋体", 12F);
            this.labelFrequency.Location = new System.Drawing.Point(1007, 28);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(40, 16);
            this.labelFrequency.TabIndex = 14;
            this.labelFrequency.Text = "频率";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "变位",
            "剥离",
            "腐蚀",
            "击穿",
            "良好",
            "裂纹",
            "侵蚀",
            "碳化",
            "污秽",
            "无光泽"});
            this.comboBox2.Location = new System.Drawing.Point(370, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(292, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "设备状态";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "开关",
            "重合器",
            "避雷器",
            "变压器",
            "隔离刀闸",
            "电缆终端盒",
            "悬式绝缘子",
            "柱式绝缘子",
            "跌落式熔断器",
            "电缆线夹绝缘套"});
            this.comboBox1.Location = new System.Drawing.Point(103, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("宋体", 12F);
            this.labelType.Location = new System.Drawing.Point(25, 66);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(72, 16);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "设备类型";
            // 
            // txtTowerNum
            // 
            this.txtTowerNum.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTowerNum.Location = new System.Drawing.Point(870, 22);
            this.txtTowerNum.Name = "txtTowerNum";
            this.txtTowerNum.Size = new System.Drawing.Size(100, 26);
            this.txtTowerNum.TabIndex = 8;
            // 
            // labelTowerNum
            // 
            this.labelTowerNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTowerNum.AutoSize = true;
            this.labelTowerNum.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTowerNum.Location = new System.Drawing.Point(792, 28);
            this.labelTowerNum.Name = "labelTowerNum";
            this.labelTowerNum.Size = new System.Drawing.Size(72, 16);
            this.labelTowerNum.TabIndex = 7;
            this.labelTowerNum.Text = "杆塔编号";
            // 
            // txtLineName
            // 
            this.txtLineName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtLineName.Location = new System.Drawing.Point(649, 25);
            this.txtLineName.Name = "txtLineName";
            this.txtLineName.Size = new System.Drawing.Size(100, 26);
            this.txtLineName.TabIndex = 6;
            // 
            // labelLineName
            // 
            this.labelLineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineName.AutoSize = true;
            this.labelLineName.Font = new System.Drawing.Font("宋体", 12F);
            this.labelLineName.Location = new System.Drawing.Point(571, 31);
            this.labelLineName.Name = "labelLineName";
            this.labelLineName.Size = new System.Drawing.Size(72, 16);
            this.labelLineName.TabIndex = 5;
            this.labelLineName.Text = "线路名称";
            // 
            // txtInspector
            // 
            this.txtInspector.Font = new System.Drawing.Font("宋体", 12F);
            this.txtInspector.Location = new System.Drawing.Point(429, 25);
            this.txtInspector.Name = "txtInspector";
            this.txtInspector.Size = new System.Drawing.Size(100, 26);
            this.txtInspector.TabIndex = 4;
            // 
            // labelInspector
            // 
            this.labelInspector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInspector.AutoSize = true;
            this.labelInspector.Font = new System.Drawing.Font("宋体", 12F);
            this.labelInspector.Location = new System.Drawing.Point(351, 31);
            this.labelInspector.Name = "labelInspector";
            this.labelInspector.Size = new System.Drawing.Size(72, 16);
            this.labelInspector.TabIndex = 3;
            this.labelInspector.Text = "检测人员";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("宋体", 12F);
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTime.Location = new System.Drawing.Point(25, 32);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(72, 16);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "检测时间";
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("宋体", 14F);
            this.home.Location = new System.Drawing.Point(40, 653);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(180, 32);
            this.home.TabIndex = 2;
            this.home.Text = "返回主页";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("宋体", 14F);
            this.delete.Location = new System.Drawing.Point(255, 653);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 32);
            this.delete.TabIndex = 3;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("宋体", 14F);
            this.cancel.Location = new System.Drawing.Point(475, 653);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(180, 32);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("宋体", 14F);
            this.save.Location = new System.Drawing.Point(696, 653);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 32);
            this.save.TabIndex = 5;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("宋体", 14F);
            this.print.Location = new System.Drawing.Point(920, 653);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(180, 32);
            this.print.TabIndex = 6;
            this.print.Text = "文档";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // datasTableAdapter
            // 
            this.datasTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.print);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.home);
            this.Controls.Add(this.detailEdit);
            this.Controls.Add(this.dataTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.Text = "历史数据";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.dataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udpcDataSet1)).EndInit();
            this.detailEdit.ResumeLayout(false);
            this.detailEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox dataTable;
        private GroupBox detailEdit;
        private DataGridView dataGridView1;
        private Label labelTowerNum;
        private TextBox txtLineName;
        private Label labelLineName;
        private TextBox txtInspector;
        private Label labelInspector;
        private DateTimePicker dateTimePicker1;
        private Label labelTime;
        private Label labelType;
        private TextBox txtTowerNum;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox txtPartialPic;
        private Button updatePartial;
        private TextBox txtOverallPic;
        private Button updateOverall;
        private Button updateNum;
        private TextBox txtNumPic;
        private TextBox txtDefect;
        private Label labelDefect;
        private TextBox txtAvg;
        private Label labelAvg;
        private TextBox txtMax;
        private Label labelMax;
        private TextBox txtLatitude;
        private Label labelLatitude;
        private TextBox txtLongitude;
        private Label labelLongitude;
        private TextBox txtHum;
        private Label labelHum;
        private TextBox txtTemp;
        private Label labelTemp;
        private TextBox txtDistance;
        private Label labelDistance;
        private TextBox txtFrequency;
        private Label labelFrequency;
        
        private Button home;
        private Button delete;
        private Button cancel;
        private Button save;
        private Button print;
        private udpcDataSet1 udpcDataSet1;
        private BindingSource datasBindingSource;
        private udpcDataSet1TableAdapters.DatasTableAdapter datasTableAdapter;
        private DataGridViewTextBoxColumn dataIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detectTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inspectorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lineNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn towerNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deviceTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deviceStateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn avgDBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numPicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn overallPicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partialPicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn audioDataGridViewTextBoxColumn;
        private OpenFileDialog openFileDialog1;
    }
}