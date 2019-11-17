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
        
        private LinkedListSV<LopHoc> CSDL_LH;
        private LinkedListSV<Nganh> CSDL_N;
        
        public QuanLyLopHocControl()
        {           
            InitializeComponent();
        }

        private void QuanLyLopHocControl_Load(object sender, EventArgs e)
        {
        }

        internal void Get_Data(LinkedListSV<LopHoc> CSDL_LH, LinkedListSV<Nganh> CSDL_N )
        {
            this.CSDL_LH = CSDL_LH;
            this.CSDL_N = CSDL_N;
            Show_Treeview();
            Show_Combobox();
            lvDanhSachLop.Items.Clear();
            cbNganh.Text = "------Mời chọn ngành------";

        }

        public void Show_Combobox()
        {
            cbNganh.Items.Clear();
            LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
            while (NodeNganh != null )
            {
                cbNganh.Items.Add(NodeNganh.data.TenNganh);
                NodeNganh = NodeNganh.pNext;
            }
        }
       
        public void Show_Treeview()
        {
            tvNganh.Nodes.Clear();
            LinkedListSV<Nganh>.Node nodeNganh = CSDL_N.pHead;
            while( nodeNganh != null )
            {
                tvNganh.Nodes.Add(nodeNganh.data.TenNganh);
                nodeNganh = nodeNganh.pNext;
            }
        }

        private void Show_ListView_Information(string tennganh)
        {
            lvDanhSachLop.Items.Clear();
            LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
            while( NodeNganh.data.TenNganh != tennganh )
            {
                NodeNganh = NodeNganh.pNext;
            }

            LinkedListSV<LopHoc>.Node NodeLop = NodeNganh.data.DsLH.pHead;

            while (NodeLop != null )
            {
                ListViewItem lviSV = new ListViewItem(NodeLop.data.MaLopHoc);
                lviSV.SubItems.Add(NodeLop.data.TenLopHoc);
                lviSV.SubItems.Add(NodeLop.data.DsSV.count.ToString());

                lvDanhSachLop.Items.Add(lviSV);
                NodeLop = NodeLop.pNext;
            }
        }

        private void tvNganh_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                Show_ListView_Information(e.Node.Text);
            }
        }

        private bool Handling_Them()
        {
            string content = "";
            Validation vali = new Validation();

            content += vali.Check_Select_Combobox("Ngành", cbNganh);
            content += vali.Check_Empty_textbox("Mã Lớp", txtMaLop);

            if ( content == "" )
            {
                LinkedListSV<LopHoc>.Node NodeLop = CSDL_LH.pHead;
                while( NodeLop != null )
                {
                    if ( NodeLop.data.MaLopHoc.ToString() == txtMaLop.Text )
                    {
                        content += "Mã lớp đã tồn tại\n";
                        break;
                    }
                    NodeLop = NodeLop.pNext;
                }
            }

            return false;
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {

        }
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {          
            Show_ListView_Information(cbNganh.Text);   
        }

        private bool Check_Add()
        {
            string content = "";
            Validation validation = new Validation();
            content += validation.Check_Combobox("Ngành", cbNganh);
            content += validation.Check_Empty_textbox("Mã lớp", txtMaLop);

            if (content == "")
            {
                LinkedListSV<LopHoc>.Node Node = CSDL_LH.pHead;
                while( Node != null )
                {
                    if ( Node.data.MaLopHoc == txtMaLop.Text )
                    {
                        content += "Mã lớp đã tồn tại!";
                        break;
                    }
                    Node = Node.pNext;
                }
            }
            content += validation.IsString("Tên lớp", txtTenLop);
            if (content != "")
            {
                MessageBox.Show(content, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            LopHoc lop = new LopHoc();
            lop.MaLopHoc = txtMaLop.Text;
            lop.TenLopHoc = txtTenLop.Text;
            /// Làm tơi đây ==> thêm ngành chủ quản
            string ngan
            LinkedListSV<Nganh>.Node NodeN = CSDL_N.pHead;
            while(NodeN.data.TenNganh != cbNganh.Text)
            {
                NodeN = NodeN.pNext;
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            

        }
    }
}
