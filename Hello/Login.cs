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

namespace Hello
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pwd = txtPwd.Text;

            //初始验证用户名密码不能为空
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("用户名不能为空");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("密码不能为空");
                txtPwd.Focus();
                return;
            }

            //从配置文件获取连接字符串
            string connStr = ConfigurationManager.ConnectionStrings["udpc"].ConnectionString;
            //建立连接
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Users where userName = '" + name + "';";
            SqlDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    if (pwd == reader["userPwd"].ToString())
                    {
                        //MessageBox.Show("正确的用户名和密码！");
                        Index form1 = new Index();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！");
                    }
                }
                else
                {
                    MessageBox.Show("没有此用户！");
                }
            }
            catch(Exception ex)
            {
                //抛出异常
                throw (new ApplicationException(ex.ToString()));
            }
            finally
            {
                //关闭数据读取
                reader.Close();
                //关闭数据库连接
                conn.Close();
            }
        }
    }
}
