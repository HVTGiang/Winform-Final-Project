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
    internal partial class ViewRelativeInfo : EditRelativeInfo
    {
        public ViewRelativeInfo()
        {
            this.Text = "Xem thông tin thân nhân";
            this.submit_button.Visible = false;
            this.ten_textBox.Enabled = false;
            this.nv_textBox.Enabled = false;
            this.sdt_textBox.Enabled = false;
            this.quanhe_comboBox.Enabled = false;
        }
    }
}
