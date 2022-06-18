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

namespace QuanLyNhanSu_LinQ.PreLayer.Relatives
{
    internal partial class EditRelativeInfo : AddNewRelative
    {
        LINQEmployeeManagement management;
        string tenCu = "";
        public EditRelativeInfo()
        {
            management = new LINQEmployeeManagement();
            this.Text = "Sửa thông tin thân nhân";
            this.submit_button.Text = "Sửa";
        }

        public void LoadData(string maNV, string ten)
        {
            ThanNhan thanNhan = management.GetThanNhan(maNV, ten);
            if (thanNhan == null) return;
            foreach (var item in quanhe_comboBox.Items)
            {
                if (Utilities.NormalizedString(item.ToString()) == thanNhan.QuanHeVoiNV)
                {
                    quanhe_comboBox.SelectedItem = item;
                    break;
                }
            }
            this.nv_textBox.Text = thanNhan.MaNV;
            this.ten_textBox.Text = thanNhan.TenTN;
            this.sdt_textBox.Text = thanNhan.Sdt;
            tenCu = this.ten_textBox.Text;
        }

        protected override void submit_button_Click(object sender, EventArgs e)
        {
            string maNV = this.nv_textBox.Text;
            string ten = this.ten_textBox.Text;
            string sdt = this.sdt_textBox.Text;
            string quanHe = this.quanhe_comboBox.Text;
            ThanNhan thanNhan = new ThanNhan(maNV, ten, quanHe, sdt);
            try
            {
                if (management.UpdateThanNhan(thanNhan))
                {
                    MessageBox.Show("Đã cập nhật thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void EditRelativeInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
