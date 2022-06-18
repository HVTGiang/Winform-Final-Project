using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_LinQ.Object
{
    public class PhongBan
    {
        private string _maPB;
        private string _tenPB;
        private string _truongPB;

        public PhongBan(string maPB, string tenPB, string truongPB)
        {
            _maPB = maPB;
            _tenPB = tenPB;
            _truongPB = truongPB;
        }

        public string MaPB { get => _maPB; }
        public string TenPB { get => _tenPB; }
        public string TruongPB { get => _truongPB; }
    }
}
