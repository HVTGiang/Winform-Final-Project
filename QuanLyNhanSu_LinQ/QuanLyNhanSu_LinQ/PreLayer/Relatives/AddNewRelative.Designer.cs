using System.Windows.Forms;

namespace QuanLyNhanSu_LinQ.PreLayer.Relatives
{
    partial class AddNewRelative
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quanhe_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ten_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sdt_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nv_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.quanhe_comboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ten_textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sdt_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nv_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 363);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancel_button);
            this.panel2.Controls.Add(this.submit_button);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 69);
            this.panel2.TabIndex = 14;
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.Location = new System.Drawing.Point(602, 22);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 30);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Hủy";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.AutoSize = true;
            this.submit_button.Location = new System.Drawing.Point(507, 22);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 30);
            this.submit_button.TabIndex = 1;
            this.submit_button.Text = "Thêm";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mục (*) là bắt buộc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(219, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "(*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(158, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(168, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(136, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "(*)";
            // 
            // quanhe_comboBox
            // 
            this.quanhe_comboBox.FormattingEnabled = true;
            this.quanhe_comboBox.Location = new System.Drawing.Point(292, 218);
            this.quanhe_comboBox.Name = "quanhe_comboBox";
            this.quanhe_comboBox.Size = new System.Drawing.Size(385, 26);
            this.quanhe_comboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên thân nhân";
            // 
            // ten_textBox
            // 
            this.ten_textBox.Location = new System.Drawing.Point(292, 115);
            this.ten_textBox.Name = "ten_textBox";
            this.ten_textBox.Size = new System.Drawing.Size(385, 27);
            this.ten_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // sdt_textBox
            // 
            this.sdt_textBox.Location = new System.Drawing.Point(292, 166);
            this.sdt_textBox.Name = "sdt_textBox";
            this.sdt_textBox.Size = new System.Drawing.Size(385, 27);
            this.sdt_textBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quan hệ với nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên";
            // 
            // nv_textBox
            // 
            this.nv_textBox.Location = new System.Drawing.Point(292, 63);
            this.nv_textBox.Name = "nv_textBox";
            this.nv_textBox.Size = new System.Drawing.Size(385, 27);
            this.nv_textBox.TabIndex = 0;
            // 
            // AddNewRelative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 363);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Name = "AddNewRelative";
            this.Text = "Thêm thân nhân";
            this.Load += new System.EventHandler(this.AddNewRelative_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        protected ComboBox quanhe_comboBox;
        private Label label4;
        protected TextBox ten_textBox;
        private Label label3;
        protected TextBox sdt_textBox;
        private Label label2;
        private Label label1;
        protected TextBox nv_textBox;
        protected Button cancel_button;
        protected Button submit_button;
    }
}