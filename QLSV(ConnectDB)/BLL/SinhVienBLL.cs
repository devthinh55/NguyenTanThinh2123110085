using System;
using System.Collections.Generic;
using System.Linq;
using QLSV_ConnectDB.DAL;
using QLSV_ConnectDB.DTO;

namespace QLSV_ConnectDB.BLL
{
    public class SinhVienBLL
    {
        private SinhVienDAL dal = new SinhVienDAL();

        public List<SinhVien> GetDS()
        {
            return dal.LayTatCa();
        }

        public string CheckAndSave(SinhVien sv, bool isUpdate)
        {
            if (string.IsNullOrWhiteSpace(sv.MaSV)) return "Mã sinh viên không được để trống!";
            if (string.IsNullOrWhiteSpace(sv.HoTen)) return "Họ tên không được để trống!";
            if (string.IsNullOrWhiteSpace(sv.DiaChi)) return "Địa chỉ không được để trống!";
            if (string.IsNullOrWhiteSpace(sv.QueQuan)) return "Vui lòng chọn Quê quán!";
            if (string.IsNullOrWhiteSpace(sv.MaLop)) return "Mã lớp không được để trống!";
            if (string.IsNullOrWhiteSpace(sv.Khoa) || sv.Khoa == "Vui lòng chọn khoa!") return "Vui lòng chọn Khoa!";
            if (string.IsNullOrWhiteSpace(sv.GioiTinh)) return "Vui lòng chọn giới tính!";

            if (!sv.MaSV.ToUpper().StartsWith("SV"))
                return "Mã sinh viên phải bắt đầu bằng 'SV'!";

            if (sv.HoTen.Any(char.IsDigit))
                return "Họ tên không được chứa chữ số!";

            if (sv.NgaySinh > DateTime.Now)
                return "Ngày sinh không được lớn hơn ngày hiện tại!";

            int tuoi = DateTime.Now.Year - sv.NgaySinh.Year;
            if (tuoi < 17 || tuoi > 50)
                return "Tuổi sinh viên phải từ 17 đến 50!";

            if (sv.NgayNhapHoc <= sv.NgaySinh.AddYears(15))
                return "Ngày nhập học phải sau ngày sinh ít nhất 15 năm!";

            if (sv.NgayNhapHoc > DateTime.Now)
                return "Ngày nhập học không được lớn hơn ngày hiện tại!";

            if (!isUpdate)
            {
                if (dal.LayTatCa().Any(x =>
                    x.MaSV.Trim().Equals(sv.MaSV.Trim(), StringComparison.OrdinalIgnoreCase)))
                    return "Mã SV này đã tồn tại trong hệ thống!";

                dal.Them(sv);
            }
            else
            {
                dal.Sua(sv);
            }

            return "OK";
        }

        public void DeleteSV(string ma)
        {
            dal.Xoa(ma);
        }

        public void DeleteMany(List<string> dsMaSV)
        {
            dal.XoaNhieu(dsMaSV);
        }

        public List<SinhVien> LocSinhVien(
            string khoa,
            string gioiTinh,
            DateTime? fromYear,
            DateTime? toYear
        )
        {
            var list = dal.LayTatCa();

            if (!string.IsNullOrWhiteSpace(khoa))
                list = list.Where(sv => sv.Khoa == khoa).ToList();

            if (!string.IsNullOrWhiteSpace(gioiTinh))
                list = list.Where(sv => sv.GioiTinh == gioiTinh).ToList();

            if (fromYear.HasValue)
                list = list.Where(sv => sv.NgayNhapHoc.Date >= fromYear.Value.Date).ToList();

            if (toYear.HasValue)
                list = list.Where(sv => sv.NgayNhapHoc.Date <= toYear.Value.Date).ToList();

            if (list.Count == 0)
                throw new Exception("Không tìm thấy sinh viên phù hợp!");

            return list;
        }
    }
}
