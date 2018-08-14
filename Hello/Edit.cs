using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace Hello
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;// 显示任务栏
            this.WindowState = FormWindowState.Maximized;// 窗体最大化
        }


        //加载
        public void Edit_Load(object sender, EventArgs e)
        {

            string connStr = ConfigurationManager.ConnectionStrings["udpc"].ConnectionString;
            //建立连接

            SqlConnection conn = new SqlConnection(connStr);//"Data Source = 127.0.0.1; Initial Catalog = udpc; User ID = sa; Password = 123456"
            //创建适配器对象;
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Datas", conn);
            //创建数据集
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable("Datas");//(+)
            adapter.Fill(ds,"Datas");//(+)
            dataGridView1.DataSource = ds.Tables["Datas"];
            //使用适配器填充数据集
            //adapter.Fill(ds, "Datas");
            //设置 DataGridView 控件的数据源
            //dataGridView1.DataSource = ds.Tables["Datas"];
            //dataGridView1.DataSource = dt;//(+)
            //this.datasTableAdapter.Fill(this.udpcDataSet1.Datas);

            //dateTimePicker1.Value = DateTime.Now;
            comboBox1.Text = "柱式绝缘子";
            comboBox2.SelectedIndex = 4;
        }


        //选中某行
        public void dataView_Click(object sender,EventArgs e)
        {
            DataGridViewRow selectRow = dataGridView1.SelectedRows[0];
            dateTimePicker1.Value = System.Convert.ToDateTime(selectRow.Cells[0].Value.ToString());
            txtInspector.Text = System.Convert.ToString(selectRow.Cells[1].Value.ToString());
            txtLineName.Text = System.Convert.ToString(selectRow.Cells[2].Value.ToString());
            txtTowerNum.Text = System.Convert.ToString(selectRow.Cells[3].Value.ToString());
            txtFrequency.Text = System.Convert.ToString(selectRow.Cells[4].Value.ToString());
            txtDistance.Text = System.Convert.ToString(selectRow.Cells[5].Value.ToString());
            txtTemp.Text = System.Convert.ToString(selectRow.Cells[6].Value.ToString());
            txtHum.Text = System.Convert.ToString(selectRow.Cells[7].Value.ToString());
            txtLongitude.Text = System.Convert.ToString(selectRow.Cells[8].Value.ToString());
            txtLatitude.Text = System.Convert.ToString(selectRow.Cells[9].Value.ToString());
            txtMax.Text = System.Convert.ToString(selectRow.Cells[10].Value.ToString());
            txtAvg.Text = System.Convert.ToString(selectRow.Cells[11].Value.ToString());
            txtDefect.Text = System.Convert.ToString(selectRow.Cells[12].Value.ToString());
            txtNumPic.Text = System.Convert.ToString(selectRow.Cells[13].Value.ToString());
            txtPartialPic.Text = System.Convert.ToString(selectRow.Cells[14].Value.ToString());
            txtOverallPic.Text = System.Convert.ToString(selectRow.Cells[15].Value.ToString());
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
        public void delete_Click(object sender,EventArgs e)
        {
            if (MessageBox.Show("确定要删除此行信息吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //取出要删除行的对象
                DataRow delRow = udpcDataSet1.Datas.Rows[dataGridView1.SelectedRows[0].Index];
                //删除行
                delRow.Delete();
                //提交到数据库
                datasTableAdapter.Update(udpcDataSet1.Datas);
                udpcDataSet1.Datas.AcceptChanges();
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
        public void save_Click(object sender,EventArgs e)
        {
            DataRow row
                = udpcDataSet1.Datas.Rows[dataGridView1.SelectedRows[0].Index];
            row["detectTime"] = dateTimePicker1.Text;
            row["inspector"] = txtInspector.Text;
            row["lineName"] = txtLineName.Text;
            row["towerNum"] = txtTowerNum.Text;
            row["deviceType"] = comboBox1.Text;
            row["deviceState"] = comboBox2.Text;
            row["frequency"] = txtFrequency.Text;
            row["distance"] = txtDistance.Text;
            row["temperature"] = txtTemp.Text;
            row["humidity"] = txtHum.Text;
            row["longitude"] = txtLongitude.Text;
            row["latitude"] = txtLatitude.Text;
            row["maxDB"] = txtMax.Text;
            row["avgDB"] = txtAvg.Text;
            row["numPic"] = txtNumPic.Text;
            row["overallPic"] = txtOverallPic.Text;
            row["partialPic"] = txtPartialPic.Text;
            row["defect"] = txtDefect.Text;

            //提交到数据库
            datasTableAdapter.Update(udpcDataSet1.Datas);
            udpcDataSet1.Datas.AcceptChanges();
        }


        /// <summary>
        /// 将字符串存储为word文档格式的文件的方法(多线程)。
        /// </summary>
        /// <param name="strText">要保存的字符串内容。</param>
        /// 需要标签
        public void print_Click(object p_str,EventArgs e)
        {
            string config = ConfigurationManager.ConnectionStrings["udpc"].ConnectionString;
            SqlConnection conn = new SqlConnection(config);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Datas where id = 1";
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word._Application word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = false;

            //Application.StartupPath -- 获取到 .exe 所在 debug 路径
            object template = System.Windows.Forms.Application.StartupPath+@"\template\template.dotx";

            object linkToFile = false;// 定义该插入图片是否为外部链接
            object saveWithDocument = true;// 定义插入图片是否随 word 文档一起保存
            string numName = "编号" + ".png";
            string replaceNumPic = System.Windows.Forms.Application.StartupPath + @"\images\" + numName;
            string overallName =  "整体" + ".png";
            string replaceOverallPic = System.Windows.Forms.Application.StartupPath + @"\images\" + overallName;
            string partialName = "缺陷" + ".png";
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
                string fileName = openFileDialog1.FileName;
                string fileRename = "编号" + Path.GetExtension(openFileDialog1.FileName);
                string localPath = System.Windows.Forms.Application.StartupPath + @"\images\" + fileRename;
                File.Copy(fileName, localPath);
                this.txtNumPic.Text = localPath;

                string config = ConfigurationManager.ConnectionStrings["udpc"].ConnectionString;
                SqlConnection conn = new SqlConnection(config);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Datas set numPic = @numPic where id = @id", conn);
                cmd.Parameters.Add(new SqlParameter("@numPic", localPath));
                cmd.Parameters.Add(new SqlParameter("@id", 1));
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
                string fileName = openFileDialog1.FileName;
                string fileRename =  "整体" + Path.GetExtension(openFileDialog1.FileName);
                string localPath = System.Windows.Forms.Application.StartupPath + @"\images\" + fileRename;
                File.Copy(fileName, localPath);
                this.txtNumPic.Text = localPath;

                string config = ConfigurationManager.ConnectionStrings["udpc"].ConnectionString;
                SqlConnection conn = new SqlConnection(config);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Datas set overallPic = @overallPic where id = @id", conn);
                cmd.Parameters.Add(new SqlParameter("@overallPic", localPath));
                cmd.Parameters.Add(new SqlParameter("@id", 1));
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
                string fileName = openFileDialog1.FileName;
                string fileRename =  "缺陷" + Path.GetExtension(openFileDialog1.FileName);
                string localPath = System.Windows.Forms.Application.StartupPath + @"\images\" + fileRename;
                File.Copy(fileName, localPath);
                this.txtNumPic.Text = localPath;

                string config = ConfigurationManager.ConnectionStrings["udpc"].ConnectionString;
                SqlConnection conn = new SqlConnection(config);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Datas set partialPic = @partialPic where id = @id", conn);
                cmd.Parameters.Add(new SqlParameter("@partialPic", localPath));
                cmd.Parameters.Add(new SqlParameter("@id", 1));
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
