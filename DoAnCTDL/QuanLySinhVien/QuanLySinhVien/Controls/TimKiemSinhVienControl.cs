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
    public partial class TimKiemSinhVienControl : UserControl
    {
        public TimKiemSinhVienControl()
        {
            InitializeComponent();
        }

        private LinkedListSV<SinhVien> CSDL_SV;
        private LinkedListSV<Nganh> CSDL_N;
        private LinkedListSV<LopHoc> CSDL_LH;

        public void Get_data(LinkedListSV<SinhVien> CSDL_SV, LinkedListSV<LopHoc> CSDL_LH, LinkedListSV<Nganh> CSDL_N)
        {
            this.CSDL_SV = CSDL_SV;
            this.CSDL_LH = CSDL_LH;
            this.CSDL_N = CSDL_N;
        }

        private void Show_Infor_Listview(string mssv)
        {
            lvThongTinTimKiem.Items.Clear();

            Validation validation = new Validation();
            string content = "";
            content += validation.IsDigit("MSSV", txtSearchMSSV);
            if ( content != "" )
            {
                MessageBox.Show(content, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LinkedListSV<SinhVien>.Node NodeSV = CSDL_SV.pHead;
            while( NodeSV != null )
            {
                if ( NodeSV.data.Id == int.Parse(txtSearchMSSV.Text) )
                {
                    ListViewItem lv = new ListViewItem(NodeSV.data.Id.ToString());
                    lv.SubItems.Add(NodeSV.data.Name.ToString());
                    string sex = NodeSV.data.Sex == true ? "Nam" : "Nữ";
                    lv.SubItems.Add(sex);
                    lv.SubItems.Add(NodeSV.data.DoB.ToDateString());
                    lv.SubItems.Add(NodeSV.data.Mscores.ToString());
                    lv.SubItems.Add(NodeSV.data.Pscores.ToString());
                    lv.SubItems.Add(NodeSV.data.Cscores.ToString());
                    lv.SubItems.Add(NodeSV.data.AvgScores().ToString());
                   
                    lv.SubItems.Add(NodeSV.data.Classmajor.TenLopHoc);

                    LinkedListSV<LopHoc>.Node NodeLop = CSDL_LH.pHead;
                    while(NodeLop != null )
                    {                 
                        if (NodeLop.data == NodeSV.data.Classmajor)
                            break;
                        NodeLop = NodeLop.pNext;
                    }
                    lv.SubItems.Add(NodeLop.data.NganhChuQuan.TenNganh);

                    lvThongTinTimKiem.Items.Add(lv);
                    break;
                }
                NodeSV = NodeSV.pNext;
            }
        }

        private void txtSearchMSSV_TextChanged(object sender, EventArgs e)
        {
            if ( txtSearchMSSV.Text != "" )
            {
                 Show_Infor_Listview(txtSearchMSSV.Text);
            }
        }
    }
}
