using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Nganh
    {
        private string maNganh;
        private string tenNganh;
        private  LinkedListSV<LopHoc> dsLH;

        public Nganh()
        {
            this.dsLH = new LinkedListSV<LopHoc>();
        }

        public string MaNganh { get; set; }
        public string TenNganh { get; set; }
         public LinkedListSV<LopHoc> DsLH {
            get { return dsLH;  }
            set { dsLH = value; }
        }
    }
}
