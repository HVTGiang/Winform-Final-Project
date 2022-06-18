using QuanLyNhanSu_LinQ.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_LinQ
{
    internal class Utilities
    {
        public static string NormalizedString(string inputString)
        {
            return inputString.Trim();
        }

        public static int ToNumber(string stringValue)
        {
            string newString = Utilities.NormalizedString(stringValue);
            return Convert.ToInt32(newString);
        }

        public static List<NhanVien> ToListNhanVien(DataTable table)
        {
            List<NhanVien> list = new List<NhanVien>();
            foreach (DataRow row in table.Rows)
            {
                NhanVien item = new NhanVien(row["MaNV"].ToString(), row["HoTen"].ToString(), row["GioiTinh"].ToString(), Convert.ToDateTime(row["NgaySinh"]), row["MaPB"].ToString(), row["TrangThai"].ToString(), Utilities.ToNumber(row["Luong"].ToString()), row["SDT"].ToString(), row["DiaChi"].ToString(), row["ChucVu"].ToString(), row["Email"].ToString(), row["ChuyenMon"].ToString(), Utilities.ToNumber(row["PhuCap"].ToString()));
                list.Add(item);
            }
            return list;
        }

        public static List<PhongBan> ToListPhongBan(DataTable table)
        {
            List<PhongBan> list = new List<PhongBan>();
            foreach (DataRow row in table.Rows)
            {
                PhongBan item = new PhongBan(row["MaPB"].ToString(), row["TenPB"].ToString(), row["MaTruongPB"].ToString());
                list.Add(item);
            }
            return list;
        }

        public static List<ThanNhan> ToListThanNhan(DataTable table)
        {
            List<ThanNhan> list = new List<ThanNhan>();
            foreach (DataRow row in table.Rows)
            {
                ThanNhan item = new ThanNhan(row["MaNV"].ToString(), row["HoTen"].ToString(), row["QuanHe"].ToString(), row["SDT"].ToString());
                list.Add(item);
            }
            return list;
        }
        public DataTable ConvertToDataTable<TSource>(IEnumerable<TSource> source)
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
    }
}
