using System.Windows.Forms;

namespace QuanLyNhanSu_LinQ
{
    partial class FormManagementBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.list_dataGridView = new System.Windows.Forms.DataGridView();
            this.form_label = new System.Windows.Forms.Label();
            this.custom_groupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.view_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_dataGridView)).BeginInit();
            this.custom_groupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.custom_groupBox);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 480);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.list_dataGridView);
            this.panel3.Controls.Add(this.form_label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 216);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(915, 279);
            this.panel3.TabIndex = 2;
            // 
            // list_dataGridView
            // 
            this.list_dataGridView.AllowUserToAddRows = false;
            this.list_dataGridView.AllowUserToDeleteRows = false;
            this.list_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_dataGridView.Location = new System.Drawing.Point(0, 29);
            this.list_dataGridView.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.list_dataGridView.Name = "list_dataGridView";
            this.list_dataGridView.ReadOnly = true;
            this.list_dataGridView.RowHeadersWidth = 51;
            this.list_dataGridView.RowTemplate.Height = 25;
            this.list_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_dataGridView.Size = new System.Drawing.Size(915, 250);
            this.list_dataGridView.TabIndex = 1;
            // 
            // form_label
            // 
            this.form_label.AutoSize = true;
            this.form_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.form_label.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.form_label.Location = new System.Drawing.Point(0, 0);
            this.form_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 21);
            this.form_label.Name = "form_label";
            this.form_label.Size = new System.Drawing.Size(304, 29);
            this.form_label.TabIndex = 0;
            this.form_label.Text = "DANH SÁCH NHÂN VIÊN";
            this.form_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custom_groupBox
            // 
            this.custom_groupBox.Controls.Add(this.panel2);
            this.custom_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.custom_groupBox.Location = new System.Drawing.Point(0, 33);
            this.custom_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.custom_groupBox.Name = "custom_groupBox";
            this.custom_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.custom_groupBox.Size = new System.Drawing.Size(915, 183);
            this.custom_groupBox.TabIndex = 1;
            this.custom_groupBox.TabStop = false;
            this.custom_groupBox.Text = "Group";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 155);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.view_button);
            this.flowLayoutPanel1.Controls.Add(this.add_button);
            this.flowLayoutPanel1.Controls.Add(this.edit_button);
            this.flowLayoutPanel1.Controls.Add(this.delete_button);
            this.flowLayoutPanel1.Controls.Add(this.update_button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(915, 33);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(4, 4);
            this.view_button.Margin = new System.Windows.Forms.Padding(4);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(85, 25);
            this.view_button.TabIndex = 6;
            this.view_button.Text = "Xem";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(97, 4);
            this.add_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(85, 25);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(190, 4);
            this.edit_button.Margin = new System.Windows.Forms.Padding(4);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(85, 25);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "Sửa";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(283, 4);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(85, 25);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "Xóa";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(376, 4);
            this.update_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(85, 25);
            this.update_button.TabIndex = 5;
            this.update_button.Text = "Cập nhật";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // FormManagementBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManagementBase";
            this.Text = "FormManagementBase";
            this.Load += new System.EventHandler(this.FormManagementBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_dataGridView)).EndInit();
            this.custom_groupBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button view_button;
        private Button add_button;
        private Button edit_button;
        private Button delete_button;
        private Button update_button;
        protected GroupBox custom_groupBox;
        protected DataGridView list_dataGridView;
        protected Label form_label;
        protected Panel panel2;
    }
}