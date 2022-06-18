using QuanLyNhanSu_LinQ.LINQManagement;
using QuanLyNhanSu_LinQ.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_LinQ.PreLayer.Employee
{
    public partial class FormManageEmployee : Form
    {
        public FormManageEmployee()
        {
            InitializeComponent();

        }

        private LINQEmployeeManagement management = new LINQEmployeeManagement();
        private void FormManageEmployee_Load(object sender, EventArgs e)
        {
             this.list_dataGridView.DataSource = management.GetAllNhanVien();
            this.list_dataGridView.Columns[0].HeaderText = "Mã nhân viên";
            this.list_dataGridView.Columns[1].HeaderText = "Tên nhân viên";
            this.list_dataGridView.Columns[2].HeaderText = "Giới tính";
            this.list_dataGridView.Columns[3].HeaderText = "Ngày sinh";
            this.list_dataGridView.Columns[4].HeaderText = "Mã phòng ban";
            this.list_dataGridView.Columns[5].HeaderText = "Trạng thái";
            this.list_dataGridView.Columns[6].HeaderText = "Lương";
            this.list_dataGridView.Columns[7].HeaderText = "Phụ cấp";
            this.list_dataGridView.Columns[8].HeaderText = "Số điện thoại";
            this.list_dataGridView.Columns[9].HeaderText = "Email";
            this.list_dataGridView.Columns[10].HeaderText = "Chuyên môn";
            this.list_dataGridView.Columns[11].HeaderText = "Chức vụ";
            this.list_dataGridView.Columns[12].HeaderText = "Địa chỉ";
        }

        

        private void add_button_Click(object sender, EventArgs e)
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.ShowDialog();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            list_dataGridView.DataSource = management.GetAllNhanVien();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            EditEmployeeInfo editEmployeeInfo = new EditEmployeeInfo();
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            editEmployeeInfo.LoadData(maNV);
            editEmployeeInfo.ShowDialog();
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            ViewEmployeeInfo viewEmployeeInfo = new ViewEmployeeInfo();
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            viewEmployeeInfo.LoadData(maNV);
            viewEmployeeInfo.ShowDialog();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //// Search with name id department and sex
            //bool isMale = this.male_radioButton.Checked;
            //string name = Utilities.NormalizedString(this.ten_textBox.Text);
            //string department = Utilities.NormalizedString(this.phongBan_comboBox.Text);
            //string id = Utilities.NormalizedString(this.maNV_textBox.Text);
            //string departmentID = management.GetMaPB(department);
            //try
            //{
            //    this.list_dataGridView.DataSource = management.Search(id, name, departmentID, isMale);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
    
}

