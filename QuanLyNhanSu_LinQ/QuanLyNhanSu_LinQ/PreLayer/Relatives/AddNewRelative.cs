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
    public partial class AddNewRelative : Form
    {
        LINQEmployeeManagement management;

        public AddNewRelative()
        {
            InitializeComponent();
            management = new LINQEmployeeManagement();
            InitComponent();
        }
        protected virtual void InitComponent()
        {
            quanhe_comboBox.DataSource = new BindingSource(DanhSachChon.QuanHeVoiNV, null);
        }

        private void AddNewRelative_Load(object sender, EventArgs e)
        {

        }
        protected virtual void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void submit_button_Click(object sender, EventArgs e)
        {
            string nv = Utilities.NormalizedString(this.nv_textBox.Text);
            string hoTen = Utilities.NormalizedString(this.ten_textBox.Text);
            string sdt = Utilities.NormalizedString(this.sdt_textBox.Text);
            string quanHe = Utilities.NormalizedString(this.quanhe_comboBox.Text);

            ThanNhan thanNhan = new ThanNhan(nv, hoTen, quanHe, sdt);
            try
            {
                management.AddThanNhan(thanNhan);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
