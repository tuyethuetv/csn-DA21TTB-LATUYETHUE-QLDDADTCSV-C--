using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiDiem
{
    internal class ketnoidulieu
    {
        public SqlConnection ketnoi;
        public SqlDataAdapter docghi;
        public SqlCommand lenh;
        public SqlCommandBuilder capnhat;

        public ketnoidulieu()
        {
            ketnoi = new SqlConnection();
            string chuoiketnoi = "Data Source=LAPTOP-1CMMB3B0\\TH1;initial Catalog=DACSN;Integrated Security=true";
            ketnoi.ConnectionString = chuoiketnoi;
        }
        public DataTable Docdulieu(string sql)
        {
            ketnoi.Open();
            docghi = new SqlDataAdapter(sql, ketnoi);
            DataTable bangtam = new DataTable();
            docghi.Fill(bangtam);
            ketnoi.Close();
            return bangtam;
        }
        public void Thaotacdulieu(string sql)
        {
            ketnoi.Open();
            lenh = new SqlCommand(sql, ketnoi);
            lenh.ExecuteNonQuery();
            ketnoi.Close();
        }
        public void Capnhatdulieu(SqlDataAdapter bdg, DataTable dt)
        {
            capnhat = new SqlCommandBuilder(bdg);
            bdg.Update(dt);

        }
    }
}
