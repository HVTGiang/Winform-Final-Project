using QuanLyNhanSu_LinQ.LINQManagement;
using QuanLyNhanSu_LinQ.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_LinQ.PreLayer.Employee
{
    public partial class ViewEmployeeInfo : Form
    {
        public LINQEmployeeManagement management;
        public ViewEmployeeInfo()
        {
            management = new LINQEmployeeManagement();
            InitializeComponent();
            InitComponent();
        }
        DataTable ConvertToDataTable<TSource>(IEnumerable<TSource> source)
        {
            var props = typeof(TSource).GetProperties();

            var dt = new DataTable();
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

        public void InitComponent()
        {
            // Centering windows to center of screen

            // Init combobox
            foreach (var value in DanhSachChon.ChucVu)
            {
                this.chucVu_comboBox.Items.Add(value);
            }
            this.chucVu_comboBox.SelectedIndex = 0;

            foreach (var value in DanhSachChon.TrangThai)
            {
                this.trangThai_comboBox.Items.Add(value);
            }
            this.trangThai_comboBox.SelectedIndex = 0;

            QuanLyNhanSuDataContext qlNS = new QuanLyNhanSuDataContext();
            IEnumerable<PHONGBAN> queryPB = from pb in qlNS.PHONGBANs select pb;
            DataTable phongBan = ConvertToDataTable<PHONGBAN>(queryPB);
            foreach (DataRow row in phongBan.Rows)
            {
                this.phongBan_comboBox.Items.Add(Utilities.NormalizedString(row["TenPB"].ToString()));
            }
            this.phongBan_comboBox.SelectedIndex = 0;

            male_radioButton.Checked = true;
        }

        public void LoadData(string maNV)
        {
            NhanVien nhanVien = management.GetNhanVien(maNV);
            if (nhanVien != null)
            {
                this.maNV_textBox.Text = nhanVien.MaNV;
                this.hoTen_textBox.Text = nhanVien.HoTen;
                this.ngaySinh_dateTimePicker.Value = nhanVien.NgaySinh.Date;
                if (nhanVien.GioiTinh == "Nam")
                {
                    this.male_radioButton.Checked = true;
                }
                else
                {
                    this.female_radioButton.Checked = true;
                }
                this.phongBan_comboBox.SelectedValue = nhanVien.MaPB;
                this.trangThai_comboBox.SelectedValue = nhanVien.TrangThai;
                this.luong_textBox.Text = nhanVien.Luong.ToString();
                this.phuCap_textBox.Text = nhanVien.PhuCap.ToString();
                this.sdt_textBox.Text = nhanVien.Sdt;
                this.email_textBox.Text = nhanVien.Email;
                this.chuyenMon_textBox.Text = nhanVien.ChuyenMon;
                this.chucVu_comboBox.SelectedValue = nhanVien.ChucVu;
                this.diaChi_textBox.Text = nhanVien.DiaChi;
            }
        }
        private void ViewEmployeeInfo_Load(object sender, EventArgs e)
        {

        }

        private void Sua_button_Click(object sender, EventArgs e)
        {

        }
    }
}
