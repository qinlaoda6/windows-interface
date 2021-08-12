using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录界面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//照片
        {

        }

        private void Form1_Load(object sender, EventArgs e)//总体窗口
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//账号
        {
             
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//密码
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//登录
        {
            string UserName = textBox1.Text;
            string Password = textBox2.Text;
             if(UserName=="123456"&&Password=="123")
            {
                 Form2 frm2 = new Form2();
                 frm2.Show();
            }
            else
            { 
              MessageBox.Show("账号或密码错误！");
            }
        }
    }
}
