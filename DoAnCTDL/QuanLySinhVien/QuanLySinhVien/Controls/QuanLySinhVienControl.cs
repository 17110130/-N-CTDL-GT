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
        private LinkedListSV<LopHoc> CSDL_LH;
        private LinkedListSV<Nganh> CSDL_N;

        public QuanLySinhVienControl()
        {
            InitializeComponent();
        }

        internal void Get_Data(LinkedListSV<SinhVien> CSDL_SV,LinkedListSV<LopHoc> CSDL_LH, LinkedListSV<Nganh> CSDL_N)
        {
            this.CSDL_SV = CSDL_SV;
            this.CSDL_LH = CSDL_LH;
            this.CSDL_N = CSDL_N;
            cbLop.Text = "--Mời chọn lớp--";
            cbNganh.Text = "--Mời chọn ngành--";
            Show_Info_ListViewSV();

        }
         
        private void Show_Info_ListViewSV()
        {
            lvThongTinSV.Items.Clear();
            LinkedListSV<SinhVien>.Node NodeSV = CSDL_SV.pHead;
            while( NodeSV != null )
            {
                ListViewItem lviSV = new ListViewItem(NodeSV.data.Id.ToString());
                lviSV.SubItems.Add(NodeSV.data.Name);
                string gioitinh = NodeSV.data.Sex == true ? "Nam" : "Nữ";
                lviSV.SubItems.Add(gioitinh);
                lviSV.SubItems.Add(NodeSV.data.DoB.ToString("dd/MM/yyyy"));
                lviSV.SubItems.Add(NodeSV.data.Mscores.ToString());
                lviSV.SubItems.Add(NodeSV.data.Pscores.ToString());
                lviSV.SubItems.Add(NodeSV.data.Cscores.ToString());
                lviSV.SubItems.Add(Math.Round(NodeSV.data.AvgScores(), 3).ToString());
                lviSV.SubItems.Add(NodeSV.data.Classmajor.TenLopHoc);
                lviSV.SubItems.Add(NodeSV.data.Classmajor.NganhChuQuan.TenNganh);

                lvThongTinSV.Items.Add(lviSV);

                NodeSV = NodeSV.pNext;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string content = "";
            Validation validation = new Validation();
            content += validation.IsDigit("MSSV", txtMSSV);
            if ( content == "" )
            {
                LinkedListSV<SinhVien>.Node NodeSV = CSDL_SV.pHead;
                while ( NodeSV != null )
                {
                    if ( NodeSV.data.Id == int.Parse(txtMSSV.Text) )
                    {
                        content += "Mã số sinh viên đã tồn tại!\n";
                    }
                    NodeSV = NodeSV.pNext;
                }
            }
            content += validation.IsString("Tên sinh viên", txtTenSinhVien);
            content += validation.Check_radio(radNam, radNu);
            content += validation.Check_Date(txtNgay, txtThang, txtNam);

        }

        private void DeleteSV(int IdDel)
        {
            // delete student 
            //for (var nodeSV = CSDL_SV.pHead; nodeSV != null; nodeSV = nodeSV.pNext)
            //{
            //    if (nodeSV.data.Id == IdDel)
            //    {
            //        CSDL_SV.RemoveNode(nodeSV);
            //        break;
            //    }
            //}
            //// delete student in class

            //for (var nodeLopHoc = CSDL_Lop.pHead; nodeLopHoc != null; nodeLopHoc = nodeLopHoc.pNext)
            //{
            //    foreach (var sinhVien in nodeLopHoc.data.DsSV)
            //    {
            //        if (sinhVien.Id == IdDel)
            //        {
            //            nodeLopHoc.data.DsSV.Remove(sinhVien);
            //            break;
            //        }
            //    }
            //}

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

       
    }
}
