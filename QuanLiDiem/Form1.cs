using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ( TaiKhoan.Text == "giangvien" && MatKhau.Text == "123")
            {
                Dashboard bds = new Dashboard();   
                bds.Show();
            }
            else if (TaiKhoan.Text == "sinhvien" && MatKhau.Text == "123")
            {
                Dashboard1 bd1 = new Dashboard1();
                bd1.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không sai!!");
            }

        }

        private void DangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
