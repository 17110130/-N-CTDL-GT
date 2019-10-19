using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class LopHoc
    {
        private string maLopHoc;
        private string tenLopHoc;
        private LinkedList<SinhVien> dsSV;

        public LopHoc()
        {
            this.dsSV = new LinkedList<SinhVien>();
        }

        public string MaLopHoc { get; set; }
        public string TenLopHoc { get; set; }

        internal LinkedList<SinhVien> DsSV { get; set; }
    }
}
