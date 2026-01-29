using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QLSV_ConnectDB.DTO;

namespace QLSV_ConnectDB.DAL
{
    public class SinhVienDAL
    {
        private string strConn =
        @"Data Source=DESKTOP-6OBQE82\SQLEXPRESS;
Initial Catalog=QLSV_ConnectDB;
Integrated Security=True;
TrustServerCertificate=True";

        public List<SinhVien> LayTatCa()
        {
            List<SinhVien> ds = new List<SinhVien>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ds.Add(new SinhVien
                    {
                        MaSV = dr["MaSV"].ToString().Trim(),
                        HoTen = dr["HoTen"].ToString(),
                        NgaySinh = Convert.ToDateTime(dr["NgaySinh"]),
                        GioiTinh = dr["GioiTinh"].ToString(),
                        QueQuan = dr["QueQuan"].ToString(),
                        DiaChi = dr["DiaChi"].ToString(),
                        NgayNhapHoc = Convert.ToDateTime(dr["NgayNhapHoc"]),
                        Khoa = dr["Khoa"].ToString(),
                        MaLop = dr["MaLop"].ToString()
                    });
                }
            }
            return ds;
        }


        public void Them(SinhVien sv)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "INSERT INTO SinhVien VALUES(@ma, @ten, @ns, @gt, @qq, @dc, @nnh, @khoa, @lop)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                MapParams(cmd, sv);
                cmd.ExecuteNonQuery();
            }
        }

        public void Sua(SinhVien sv)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "UPDATE SinhVien SET HoTen=@ten, NgaySinh=@ns, GioiTinh=@gt, QueQuan=@qq, DiaChi=@dc, NgayNhapHoc=@nnh, Khoa=@khoa, MaLop=@lop WHERE MaSV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                MapParams(cmd, sv);
                cmd.ExecuteNonQuery();
            }
        }

        public void Xoa(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM SinhVien WHERE MaSV=@ma", conn);
                cmd.Parameters.AddWithValue("@ma", maSV);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaNhieu(List<string> dsMaSV)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                foreach (string ma in dsMaSV)
                {
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM SinhVien WHERE MaSV=@ma", conn);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void MapParams(SqlCommand cmd, SinhVien sv)
        {
            cmd.Parameters.AddWithValue("@ma", sv.MaSV);
            cmd.Parameters.AddWithValue("@ten", sv.HoTen);
            cmd.Parameters.AddWithValue("@ns", sv.NgaySinh);
            cmd.Parameters.AddWithValue("@gt", sv.GioiTinh);
            cmd.Parameters.AddWithValue("@qq", sv.QueQuan ?? "");
            cmd.Parameters.AddWithValue("@dc", sv.DiaChi);
            cmd.Parameters.AddWithValue("@nnh", sv.NgayNhapHoc);
            cmd.Parameters.AddWithValue("@khoa", sv.Khoa ?? "");
            cmd.Parameters.AddWithValue("@lop", sv.MaLop);
        }
    }
}