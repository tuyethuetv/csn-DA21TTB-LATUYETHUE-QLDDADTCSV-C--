using QuanLiDiem.DACSNDataSet1TableAdapters;
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
    public partial class diemda : UserControl
    {
        public diemda()
        {
            InitializeComponent();
        }
        ketnoidulieu ketnoi = new ketnoidulieu();
        SqlDataAdapter bodocghi;
        DataTable bangdiem = new DataTable();
        int donghh;

        void Hienthidulieu()
        {
            string sql = "select* from bangdiem";
            bangdiem = ketnoi.Docdulieu(sql);
            bodocghi = ketnoi.docghi;
            dgvdiem.DataSource = bangdiem;
        }
        void Hiensinhvien()
        {
            string sql = "select* from sinhvien";
            cbmasv.DataSource = ketnoi.Docdulieu(sql);
            cbmasv.DisplayMember = "masv";
            cbmasv.ValueMember = "masv";
        }
        void Hiendoan()
        {
            string sql = "select* from doan";
            cbmada.DataSource = ketnoi.Docdulieu(sql);
            cbmada.DisplayMember = "mada";
            cbmada.ValueMember = "mada";
        }

        private void diemda_Load(object sender, EventArgs e)
        {
            Hienthidulieu();
            Hiendoan();
            Hiensinhvien();
        }

        private void dgvdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                cbmasv.SelectedValue = bangdiem.Rows[donghh][0].ToString();
                cbmada.SelectedValue = bangdiem.Rows[donghh][1].ToString();
                txtdiem.Text = bangdiem.Rows[donghh][2].ToString();

            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtdiem.Text != "")
            {
                DataRow dongmoi = bangdiem.NewRow();
                dongmoi["diem"] = txtdiem.Text;
                dongmoi["masv"] = cbmasv.SelectedValue;
                dongmoi["mada"] = cbmada.SelectedValue;
                bangdiem.Rows.Add(dongmoi);
                ketnoi.Capnhatdulieu(bodocghi, bangdiem);
                bangdiem.Clear();
                Hienthidulieu();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                bangdiem.Rows[donghh].Delete();
                ketnoi.Capnhatdulieu(bodocghi, bangdiem);
                bangdiem.Clear();
                Hienthidulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!!");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            bangdiem.Rows[donghh]["diem"] = txtdiem.Text;
            bangdiem.Rows[donghh]["masv"] = cbmasv.SelectedValue;
            bangdiem.Rows[donghh]["mada"] = cbmada.SelectedValue;
            //cap nhat CSDL
            ketnoi.Capnhatdulieu(bodocghi, bangdiem);
            bangdiem.Clear();
            Hienthidulieu();
        }

        private void btxuat_Click(object sender, EventArgs e)
        {
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchtext_hoten = txttimkiem.Text.Trim();
            DataView dataView = new DataView(bangdiem);
            dataView.RowFilter = $"masv LIKE '%{searchtext_hoten}%'";
            dgvdiem.DataSource = dataView;
        }
    }
}
