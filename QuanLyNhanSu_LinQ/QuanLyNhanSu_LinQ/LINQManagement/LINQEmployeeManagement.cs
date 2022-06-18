using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Reflection;
using QuanLyNhanSu_LinQ.Object;
using System.Windows.Forms;

namespace QuanLyNhanSu_LinQ.LINQManagement
{
    public partial class LINQEmployeeManagement
    {

        #region Convert to DataTable
        DataTable ConvertToDataTable<TSource>(IEnumerable<TSource> source)
        {
            var props = typeof(TSource).GetProperties();

            var dt = new DataTable();
            //dt.Columns.AddRange(
            //  props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray()
            //);

            //source.ToList().ForEach(
            //  i => dt.Rows.Add(props.Select(p => p.GetValue(i, null)).ToArray())
            //);
            foreach (var prop in props)
            {
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in source)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                dt.Rows.Add(values);
            }

            return dt;
        }
        #endregion

        #region Quản lý NhanVien
        public Table<NHANVIEN> GetAllNhanVien()
        {
            QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext();
            return qlNS.NHANVIENs;
        }

        public bool AddNhanVien(NhanVien nhanVien)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = nhanVien.MaNV;
                nv.NGAYSINH = nhanVien.NgaySinh;
                nv.GIOITINH = nhanVien.GioiTinh;
                nv.HOTEN = nhanVien.HoTen;
                nv.MAPB = nhanVien.MaPB;
                nv.TRANGTHAI = nhanVien.TrangThai;
                nv.LUONG = nhanVien.Luong;
                nv.PHUCAP = nhanVien.PhuCap;
                nv.SDT = nhanVien.Sdt;
                nv.EMAIL = nhanVien.Email;
                nv.CHUYENMON = nhanVien.ChuyenMon;
                nv.CHUCVU = nhanVien.ChucVu;
                nv.DIACHI = nhanVien.DiaChi;
                qlNS.NHANVIENs.InsertOnSubmit(nv);
                qlNS.NHANVIENs.Context.SubmitChanges();
                return true;
            }
        }

        public NhanVien GetNhanVien(string maNV)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<NHANVIEN> queryGetNV = qlNS.NHANVIENs.Where(p => p.MANV.CompareTo(maNV) == 0);
                DataTable nhanVien = ConvertToDataTable<NHANVIEN>(queryGetNV);
                List<NhanVien> list = Utilities.ToListNhanVien(nhanVien);
                return list[0];
            }
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {

            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                NHANVIEN nvQuery = qlNS.NHANVIENs.Where(p => p.MANV.Equals(nhanVien.MaNV)).SingleOrDefault();

                if (nvQuery != null)
                {
                    nvQuery.MANV = nhanVien.MaNV;
                    nvQuery.NGAYSINH = nhanVien.NgaySinh;
                    nvQuery.GIOITINH = nhanVien.GioiTinh;
                    nvQuery.HOTEN = nhanVien.HoTen;
                    nvQuery.MAPB = nhanVien.MaPB;
                    nvQuery.TRANGTHAI = nhanVien.TrangThai;
                    nvQuery.LUONG = nhanVien.Luong;
                    nvQuery.PHUCAP = nhanVien.PhuCap;
                    nvQuery.SDT = nhanVien.Sdt;
                    nvQuery.EMAIL = nhanVien.Email;
                    nvQuery.CHUYENMON = nhanVien.ChuyenMon;
                    nvQuery.CHUCVU = nhanVien.ChucVu;
                    nvQuery.DIACHI = nhanVien.DiaChi;
                    qlNS.NHANVIENs.Context.SubmitChanges();
                }
                return true;
            }
        }
        #endregion

        #region Quản lý PhongBan
        public Table<PHONGBAN> GetAllPhongBan()
        {
            QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext();
            return qlNS.PHONGBANs;
        }

        public string GetMaPB(string tenPB)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<PHONGBAN> queryPB = qlNS.PHONGBANs.Where(p => p.TENPB.CompareTo(tenPB) == 0);
                DataTable maPB = ConvertToDataTable<PHONGBAN>(queryPB);
                if (maPB.Rows.Count > 0)
                {
                    return Utilities.NormalizedString(maPB.Rows[0][0].ToString());
                }
                else
                {
                    return "";
                }
            }

        }
        #endregion

        #region Quản lí Thân Nhân

        public Table<THANNHAN> GetAllThanNhan()
        {
            QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext();
            return qlNS.THANNHANs;
        }

        public bool AddThanNhan(ThanNhan thanNhan)
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                THANNHAN tn = new THANNHAN();
                tn.SDT = thanNhan.Sdt;
                tn.MANV = thanNhan.MaNV;
                tn.HOTEN = thanNhan.TenTN;
                tn.QUANHE = thanNhan.QuanHeVoiNV;

                qlNS.THANNHANs.InsertOnSubmit(tn);
                qlNS.THANNHANs.Context.SubmitChanges();
                return true;
            }
        }

        public ThanNhan GetThanNhan(string maNV, string HoTen = "")
        {
            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                IEnumerable<THANNHAN> queryGetTN;
                if (HoTen == "")
                {
                    queryGetTN = (from p in qlNS.THANNHANs
                                  where p.MANV.CompareTo(maNV) == 0
                                  where p.HOTEN == HoTen
                                  select p);
                }
                else
                {
                    queryGetTN = (from p in qlNS.THANNHANs
                                  where p.MANV.CompareTo(maNV) == 0
                                  select p);
                }
                DataTable thanNhan = ConvertToDataTable<THANNHAN>(queryGetTN);
                List<ThanNhan> list = Utilities.ToListThanNhan(thanNhan);
                return list[0];
            }
        }
        public bool UpdateThanNhan(ThanNhan thanNhan)
        {

            using (QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext())
            {
                var nvQuery = (from p in qlNS.THANNHANs
                               where p.MANV.CompareTo(thanNhan.MaNV) == 0
                               where p.HOTEN == thanNhan.TenTN
                               select p).SingleOrDefault();

                if (nvQuery != null)
                {
                    nvQuery.MANV = thanNhan.MaNV;
                    nvQuery.SDT = thanNhan.Sdt;
                    nvQuery.HOTEN = thanNhan.TenTN;
                    nvQuery.QUANHE = thanNhan.QuanHeVoiNV;
                    qlNS.THANNHANs.Context.SubmitChanges();
                }
                return true;
            }
        }

        public bool RemoveThanNhan(string maNV, string hoTen)
        {
            QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext();
            var queryGetTN = (from p in qlNS.THANNHANs
                              where p.MANV.CompareTo(maNV) == 0
                              where p.HOTEN == hoTen
                              select p).SingleOrDefault();
            try
            {
                if (queryGetTN != null)
                {
                    qlNS.THANNHANs.DeleteOnSubmit(queryGetTN);
                    qlNS.THANNHANs.Context.SubmitChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error ! " + ex.Message, "Information");
                return false;
            }
        }
        #endregion




    }
}
