using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class LopHoc
    {

        public LopHoc()
        {
            this.dsSV = new LinkedListSV<SinhVien>();
        }

        private string maLopHoc;
        private string tenLopHoc;
        private Nganh nganhChuQuan;
        private LinkedListSV<SinhVien> dsSV;

        public string MaLopHoc
        {
            get {return maLopHoc; }
            set { maLopHoc = value; }
        }
        public string TenLopHoc {
            get { return tenLopHoc; }
            set { tenLopHoc = value; }
        }

        public Nganh NganhChuQuan
        {
            get { return nganhChuQuan; }
            set { nganhChuQuan = value; }
        }

        internal LinkedListSV<SinhVien> DsSV 
        {
            get { return dsSV; }
            set { dsSV = value; }
        }


    }
}
