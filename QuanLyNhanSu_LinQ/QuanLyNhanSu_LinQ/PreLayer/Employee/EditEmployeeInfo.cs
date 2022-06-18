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
    public partial class EditEmployeeInfo : Form
    {
        public LINQEmployeeManagement management;
        public EditEmployeeInfo()
        {
            management = new LINQEmployeeManagement();
            InitializeComponent();
            InitComponent();
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


        private void EditEmployeeInfo_Load(object sender, EventArgs e)
        {

        }

        public NhanVien CreateCurrentNhanVien()
        {
            string maNV = Utilities.NormalizedString(this.maNV_textBox.Text).ToUpper();
            string hoTen = Utilities.NormalizedString(this.hoTen_textBox.Text);
            string gioiTinh = male_radioButton.Checked == true ? "Nam" : "Nu";
            string diaChi = Utilities.NormalizedString(this.diaChi_textBox.Text);
            string chuyenMon = Utilities.NormalizedString(this.chuyenMon_textBox.Text);
            DateTime ngaySinh = this.ngaySinh_dateTimePicker.Value.Date;
            string email = Utilities.NormalizedString(this.email_textBox.Text);
            string sdt = Utilities.NormalizedString(this.sdt_textBox.Text);
            int luong = Utilities.ToNumber(this.luong_textBox.Text);
            int phuCap = Utilities.ToNumber(this.phuCap_textBox.Text);
            string chucVu = Utilities.NormalizedString(this.chucVu_comboBox.Text);
            string phongBan = Utilities.NormalizedString(this.phongBan_comboBox.Text);
            string maPB = management.GetMaPB(phongBan);
            string trangThai = Utilities.NormalizedString(this.trangThai_comboBox.Text);
            return new NhanVien(maNV, hoTen, gioiTinh, ngaySinh, maPB, trangThai, luong, sdt, diaChi, chucVu, email, chuyenMon, phuCap);
        }

        private void Sua_button_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = CreateCurrentNhanVien();
                if (management.UpdateNhanVien(nhanVien))
                {
                    MessageBox.Show("Sửa nhân viên thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
