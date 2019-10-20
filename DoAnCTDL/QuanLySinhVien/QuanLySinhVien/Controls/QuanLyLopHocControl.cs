using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class QuanLyLopHocControl : UserControl
    {

        private LinkedListSV<SinhVien> CSDL_SV;
        private LinkedListSV<LopHoc> CSDL_Lop;

        public QuanLyLopHocControl()
        {
            
            InitializeComponent();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {

        }
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvLopHoc.Rows)
            {
                if ((bool)item.Cells[0].Value)
                {

                }
            }
        }
        //private void XoaLopHoc()
        //{
        //    if()
        //}


    }
}
