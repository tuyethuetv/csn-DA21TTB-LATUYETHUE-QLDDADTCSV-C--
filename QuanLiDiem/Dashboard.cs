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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            diemda1.Visible = true;
            diemda1.BringToFront();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            diemda1.Visible = false;
            quanlisv1.Visible=false;
            quanligiangvien1.Visible=false;
            doan1.Visible=false;
            thongke1.Visible=false;
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            doan1.Visible=true;
            doan1.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            quanligiangvien1.Visible=true;
            quanligiangvien1.BringToFront();

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            quanlisv1.Visible = true;
            quanlisv1.BringToFront();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void diemda1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click_1(object sender, EventArgs e)
        {
            thongke1.Visible=true;
            thongke1.BringToFront();
        }
    }
}
