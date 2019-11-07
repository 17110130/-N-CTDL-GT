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
            lvDanhSachLop.Items.Clear();

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

        private void Show_Information_SV(string tennganh)
        {
            lvDanhSachLop.Items.Clear();
            LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
            while( NodeNganh.data.TenNganh != tennganh )
            {
                NodeNganh = NodeNganh.pNext;
            }

            LinkedListSV<LopHoc>.Node NodeLop = CSDL_LH.pHead;
            while(NodeLop.data != null )
            {
                ListViewItem lviSV = new ListViewItem(NodeLop.data.MaLopHoc);
                lviSV.SubItems.Add(NodeLop.data.TenLopHoc);
                lviSV.SubItems.Add(NodeLop.data.dsSV.count.ToString());

                lvDanhSachLop.Items.Add(lviSV);
                NodeLop = NodeLop.pNext;
            }
        }
        private void btnSuaLop_Click(object sender, EventArgs e)
        {

        }
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow item in dgvLopHoc.Rows)
            //{
            //    if ((bool)item.Cells[0].Value)
            //    {

            //    }
            //}
        }

        private void tvNganh_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                Show_Information_SV(e.Node.Text);
            }
        }

        
        //private void XoaLopHoc()
        //{
        //    if()
        //}


    }
}
