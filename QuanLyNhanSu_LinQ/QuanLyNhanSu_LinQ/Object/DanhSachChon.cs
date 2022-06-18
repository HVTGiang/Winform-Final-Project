using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_LinQ.Object
{
    public static class DanhSachChon
    {
        public static List<string> ChucVu = new List<string>()
        {
            "Trưởng phòng",
            "Nhân viên"
        };

        public static List<string> TrangThai = new List<string>()
        {
            "Đang công tác",
            "Đã nghỉ"
        };

        public static List<string> GioiTinh = new List<string>()
        {
            "Nam",
            "Nữ"
        };

        public static List<string> QuanHeVoiNV = new List<string>()
        {
            "Bo/Me",
            "Anh/Chi/Em",
            "Vo/Chong",
            "Nguoi than",
            "Ong/Ba",
            "Con"
        };
    }
}
