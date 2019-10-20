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
    public partial class QuanLySinhVienControl : UserControl
    {
        private LinkedListSV<SinhVien> CSDL_SV;
        private LinkedListSV<LopHoc> CSDL_Lop;

        public QuanLySinhVienControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DeleteSV(int IdDel)
        {
            // delete student 
            for (var nodeSV = CSDL_SV.pHead; nodeSV != null; nodeSV = nodeSV.pNext)
            {
                if (nodeSV.data.Id == IdDel)
                {
                    CSDL_SV.RemoveNode(nodeSV);
                    break;
                }
            }
            // delete student in class

            for (var nodeLopHoc = CSDL_Lop.pHead; nodeLopHoc != null; nodeLopHoc = nodeLopHoc.pNext)
            {
                foreach (var sinhVien in nodeLopHoc.data.DsSV)
                {
                    if (sinhVien.Id == IdDel)
                    {
                        nodeLopHoc.data.DsSV.Remove(sinhVien);
                        break;
                    }
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
