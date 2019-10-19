using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Nganh
    {
        private string maNghanh;
        private string tenNganh;
        private LinkedList<LopHoc> dsLH;

        public Nganh()
        {
            this.dsLH = new LinkedList<LopHoc>();
        }

        public string MaNganh { get; set; }
        public string TenNganh { get; set; }
        internal LinkedList<LopHoc> DsLH { get; set; }
    }
}
