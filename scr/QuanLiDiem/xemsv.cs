using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiem
{
    public partial class xemsv : UserControl
    {
        public xemsv()
        {
            InitializeComponent();
        }
        ketnoidulieu ketnoi = new ketnoidulieu();
        SqlDataAdapter bodocghi;
        DataTable bangqlsv = new DataTable();
        int donghh;


        void Hienthidulieu()
        {
            string sql = "select* from sinhvien";
            bangqlsv = ketnoi.Docdulieu(sql);
            bodocghi = ketnoi.docghi;
            gunaDataGridView1.DataSource = bangqlsv;
        }
            private void xemsv_Load(object sender, EventArgs e)
        {
            Hienthidulieu();
        }
    }
}
