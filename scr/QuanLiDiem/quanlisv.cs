using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiDiem
{
    public partial class quanlisv : UserControl
    {
        public quanlisv()
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
            dgvquanlisv.DataSource = bangqlsv;
        }
        private void quanlisv_Load(object sender, EventArgs e)
        {
            Hienthidulieu();
        }

        private void gunaContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text != "")
            {
                DataRow dongmoi = bangqlsv.NewRow();
                dongmoi["masv"] = txtmasv.Text;
                dongmoi["hotensv"] = txthoten.Text;
                dongmoi["ngaysinhsv"] = dtngaysinh.Text;
                dongmoi["lop"] = txtlop.Text;
                dongmoi["nganhhoc"]=txtnganhhoc.Text;
                bangqlsv.Rows.Add(dongmoi);
                ketnoi.Capnhatdulieu(bodocghi, bangqlsv);
                bangqlsv.Clear();
                Hienthidulieu();
            }
        }

        private void dgvquanlisv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtmasv.Text = bangqlsv.Rows[donghh][0].ToString();
                txthoten.Text = bangqlsv.Rows[donghh][1].ToString();
                dtngaysinh.Text = bangqlsv.Rows[donghh][2].ToString();
                txtlop.Text = bangqlsv.Rows[donghh][3].ToString();
                txtnganhhoc.Text = bangqlsv.Rows[donghh][4].ToString();
                txtmasv.Enabled = false;

            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                bangqlsv.Rows[donghh].Delete();
                ketnoi.Capnhatdulieu(bodocghi, bangqlsv);
                bangqlsv.Clear();
                Hienthidulieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!!");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            bangqlsv.Rows[donghh]["masv"] = txtmasv.Text;
            bangqlsv.Rows[donghh]["hotensv"] = txthoten.Text;
            bangqlsv.Rows[donghh]["ngaysinhsv"] = dtngaysinh.Text;
            bangqlsv.Rows[donghh]["lop"] = txtlop.Text;
            bangqlsv.Rows[donghh]["nganhhoc"] = txtnganhhoc.Text;
            ketnoi.Capnhatdulieu(bodocghi, bangqlsv);
            bangqlsv.Clear();
            Hienthidulieu();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

            string searchtext_hoten = txttimkiem.Text.Trim();
            DataView dataView = new DataView(bangqlsv);
            dataView.RowFilter = $"hotensv LIKE '%{searchtext_hoten}%'";
            dgvquanlisv.DataSource = dataView;
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select* from sinhvien where hotensv like '%" + txttimkiem + "%'";
            DataTable bangtam = new DataTable();
            bangtam = ketnoi.Docdulieu(sql);
            dgvquanlisv.Refresh();
            dgvquanlisv.DataSource = bangtam;
        }
    }
}
