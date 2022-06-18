using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_LinQ.Object
{
    public class NhanVien
    {
        private string _maNV;
        private string _hoTen;
        private string _gioiTinh;
        private DateTime _ngaySinh;
        private string _maPB;
        private string _trangThai;
        private int _luong;
        private int _phuCap;
        private string _sdt;
        private string _email;
        private string _chuyenMon;
        private string _chucVu;
        private string _diaChi;

        public NhanVien(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string maPB, string trangThai, int luong, string sdt, string diaChi, string chucVu, string email = "", string chuyenMon = "", int phuCap = 0)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _gioiTinh = gioiTinh;
            _ngaySinh = ngaySinh;
            _maPB = maPB;
            _trangThai = trangThai;
            _luong = luong;
            _phuCap = phuCap;
            _sdt = sdt;
            _email = email;
            _chuyenMon = chuyenMon;
            _chucVu = chucVu;
            _diaChi = diaChi;
        }

        public string MaNV { get => _maNV; }
        public string HoTen { get => _hoTen; }
        public string GioiTinh { get => _gioiTinh; }
        public DateTime NgaySinh { get => _ngaySinh; }
        public string MaPB { get => _maPB; }
        public string TrangThai { get => _trangThai; }
        public int Luong { get => _luong; }
        public int PhuCap { get => _phuCap; }
        public string Sdt { get => _sdt; }
        public string Email { get => _email; }
        public string ChuyenMon { get => _chuyenMon; }
        public string ChucVu { get => _chucVu; }
        public string DiaChi { get => _diaChi; }
    }
}
