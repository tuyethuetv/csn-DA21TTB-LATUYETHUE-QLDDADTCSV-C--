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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            xemsv1.Visible = true;
            xemsv1.BringToFront();
        }

        private void xemsv1_Load(object sender, EventArgs e)
        {
            xemsv1.Visible=false;
        }
    }
}
