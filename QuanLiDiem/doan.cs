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
    public partial class doan : UserControl
    {
        public doan()
        {
            InitializeComponent();
        }
        ketnoidulieu ketnoi = new ketnoidulieu();
        SqlDataAdapter bodocghi;
        DataTable bangdoan = new DataTable();
        int donghh;

        void Hienthidulieu()
        {
            string sql = "select* from doan";
            bangdoan = ketnoi.Docdulieu(sql);
            bodocghi = ketnoi.docghi;
            dgvbangdoan.DataSource = bangdoan;
        }
        void Hiengiangvien()
        {
            string sql = "select* from giangvien";
            cbmagv.DataSource = ketnoi.Docdulieu(sql);
            cbmagv.DisplayMember = "tengv";
            cbmagv.ValueMember = "magv";
        }

        private void doan_Load(object sender, EventArgs e)
        {
            Hienthidulieu();
            Hiengiangvien();
        }

        private void dgvbangdoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtmada.Text = bangdoan.Rows[donghh][0].ToString();
                txttenda.Text = bangdoan.Rows[donghh][1].ToString();
                txtmota.Text = bangdoan.Rows[donghh][2].ToString();
                cbmagv.SelectedValue = bangdoan.Rows[donghh][3].ToString(); ;
                txtmada.Enabled = false;
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtmada.Text != "")
            {
                DataRow dongmoi = bangdoan.NewRow();
                dongmoi["mada"] = txtmada.Text;
                dongmoi["tenda"] = txttenda.Text;
                dongmoi["mota"] = txtmota.Text;
                dongmoi["magv"] = cbmagv.SelectedValue;
                bangdoan.Rows.Add(dongmoi);
                ketnoi.Capnhatdulieu(bodocghi, bangdoan);
                bangdoan.Clear();
                Hienthidulieu();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                bangdoan.Rows[donghh].Delete();
                ketnoi.Capnhatdulieu(bodocghi, bangdoan);
                bangdoan.Clear();
                Hienthidulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!!");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            bangdoan.Rows[donghh][0] = txtmada.Text;
            bangdoan.Rows[donghh][1] = txttenda.Text;
            bangdoan.Rows[donghh][2] = txtmota.Text;
            bangdoan.Rows[donghh][3] = cbmagv.SelectedValue;
            ketnoi.Capnhatdulieu(bodocghi, bangdoan);
            bangdoan.Clear();
            Hienthidulieu();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchtext_hoten = txttimkiem.Text.Trim();
            DataView dataView = new DataView(bangdoan);
            dataView.RowFilter = $"tenda LIKE '%{searchtext_hoten}%'";
            dgvbangdoan.DataSource = dataView;
        }
    }
}
