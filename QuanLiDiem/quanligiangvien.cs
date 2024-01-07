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
    public partial class quanligiangvien : UserControl
    {
        public quanligiangvien()
        {
            InitializeComponent();
        }
        ketnoidulieu ketnoi = new ketnoidulieu();
        SqlDataAdapter bodocghi;
        DataTable banggiangvien = new DataTable();
        int donghh;

        void Hienthidulieu()
        {
            string sql = "select* from giangvien";
            banggiangvien = ketnoi.Docdulieu(sql);
            bodocghi = ketnoi.docghi;
            dgvgiangvien.DataSource = banggiangvien;
        }
        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtmagv.Text = banggiangvien.Rows[donghh][0].ToString();
                txthoten.Text = banggiangvien.Rows[donghh][1].ToString();
                dtngaysinh.Text = banggiangvien.Rows[donghh][2].ToString();
                txtkhoa.Text = banggiangvien.Rows[donghh][3].ToString();
                txtbomon.Text = banggiangvien.Rows[donghh][4].ToString();
                txtmagv.Enabled = false;

            }
        }

        private void quanligiangvien_Load(object sender, EventArgs e)
        {
            Hienthidulieu();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtmagv.Text != "")
            {
                DataRow dongmoi = banggiangvien.NewRow();
                dongmoi["magv"] = txtmagv.Text;
                dongmoi["hoten"] = txthoten.Text;
                dongmoi["ngaysinh"] = dtngaysinh.Text;
                dongmoi["khoa"] = txtkhoa.Text;
                dongmoi["bomon"] = txtbomon.Text;
                banggiangvien.Rows.Add(dongmoi);
                ketnoi.Capnhatdulieu(bodocghi, banggiangvien);
                banggiangvien.Clear();
                Hienthidulieu();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                banggiangvien.Rows[donghh].Delete();
                ketnoi.Capnhatdulieu(bodocghi, banggiangvien);
                banggiangvien.Clear();
                Hienthidulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!!");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            banggiangvien.Rows[donghh][0] = txtmagv.Text;
            banggiangvien.Rows[donghh][1] = txthoten.Text;
            banggiangvien.Rows[donghh][2] = dtngaysinh.Text;
            banggiangvien.Rows[donghh][3] = txtkhoa.Text;
            banggiangvien.Rows[donghh][4] = txtbomon.Text;
            ketnoi.Capnhatdulieu(bodocghi, banggiangvien);
            banggiangvien.Clear();
            Hienthidulieu();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchtext_hoten = txttimkiem.Text.Trim();
            DataView dataView = new DataView(banggiangvien);
            dataView.RowFilter = $"hoten LIKE '%{searchtext_hoten}%'";
            dgvgiangvien.DataSource = dataView;
        }
    }
}
