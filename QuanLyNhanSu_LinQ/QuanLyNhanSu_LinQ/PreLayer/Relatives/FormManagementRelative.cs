using QuanLyNhanSu_LinQ.LINQManagement;
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
    public partial class FormManagementRelative : FormManagementBase
    {
        private LINQEmployeeManagement management;

        public FormManagementRelative() : base()
        {
            management = new LINQEmployeeManagement();
            InitializeComponent();
        }

        protected override void add_button_Click(object sender, EventArgs e)
        {
            AddNewRelative addNewRelative = new AddNewRelative();
            addNewRelative.ShowDialog();
            this.RefreshForm();
        }

        protected override void edit_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            EditRelativeInfo editRelativeInfo = new EditRelativeInfo();
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            string ten = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[1].Value.ToString());
            editRelativeInfo.LoadData(maNV, ten);
            editRelativeInfo.ShowDialog();
            this.RefreshForm();

        }

        protected override void view_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            ViewRelativeInfo viewRelativeInfo = new ViewRelativeInfo();
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            string ten = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[1].Value.ToString());

            viewRelativeInfo.LoadData(maNV, ten);
            viewRelativeInfo.ShowDialog();
        }

        protected override void update_button_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        protected override void delete_button_Click(object sender, EventArgs e)
        {
            if (list_dataGridView.CurrentRow == null) return;
            string maNV = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[0].Value.ToString());
            string hoTen = Utilities.NormalizedString(list_dataGridView.CurrentRow.Cells[1].Value.ToString());
            try
            {
                if (management.RemoveThanNhan(maNV, hoTen))
                {
                    MessageBox.Show("Xóa thành công");
                    this.RefreshForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /*protected override void InitializeAdditionalComponent()
        {

        }*/

        protected void RefreshForm()
        {
            list_dataGridView.DataSource = management.GetAllThanNhan();
        }

        private void InitializeComponent()
        {
            this.custom_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // custom_groupBox
            // 
            this.custom_groupBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.custom_groupBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.custom_groupBox.Size = new System.Drawing.Size(1144, 206);
            // 
            // form_label
            // 
            this.form_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 24);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(5, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Size = new System.Drawing.Size(1134, 178);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FormManagementRelative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.ClientSize = new System.Drawing.Size(1144, 540);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormManagementRelative";
            this.Text = "Quản lí thân nhân";
            this.Load += new System.EventHandler(this.FormManageRelative_Load);
            this.custom_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void FormManageRelative_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
