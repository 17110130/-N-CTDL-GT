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

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            LinkedListSV<LopHoc>.Node NodeLop = CSDL_LH.pHead;
            string nganh = cbNganh.GetItemText(cbNganh.SelectedItem);
            while (NodeLop != null)
            {
                if (NodeLop.data.MaLopHoc == txtMaLop.Text)
                {
                    NodeLop.data.TenLopHoc = txtTenLop.Text;
                    LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
                    while (NodeNganh != null)
                    {
                        if (NodeNganh.data.TenNganh == nganh)
                            break;
                        NodeNganh = NodeNganh.pNext;
                    }
                    NodeLop.data.NganhChuQuan = NodeNganh.data;
                }
                NodeLop = NodeLop.pNext;
            }

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show_ListView_Information(tvNganh.SelectedNode.Text);
            Clear();
        }

        private void Handling_Delete(string msLHDel)
        {
            if ( lvDanhSachLop.SelectedItems.Count > 0 )
            {
                // XÓa trong CSDL_LH
                LinkedListSV<LopHoc>.Node NodeLopDel = CSDL_LH.pHead;
                string tennganh = "";
                while( NodeLopDel != null )
                {
                    if ( NodeLopDel.data.MaLopHoc == msLHDel )
                    {
                        tennganh = NodeLopDel.data.NganhChuQuan.TenNganh;
                        CSDL_LH.RemoveNode(NodeLopDel);
                        break;
                    }
                    NodeLopDel = NodeLopDel.pNext;
                }

                // XÓa trong CSDL_N
                LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
                while(NodeNganh != null )
                {
                    if ( NodeNganh.data.TenNganh == tennganh )
                    {
                        LinkedListSV<LopHoc>.Node NodeDsLop = NodeNganh.data.DsLH.pHead;
                        while( NodeDsLop != null )
                        {
                            if ( NodeDsLop.data.MaLopHoc == msLHDel )
                            {
                                NodeNganh.data.DsLH.RemoveNode(NodeDsLop);
                                break;
                            }
                            NodeDsLop = NodeDsLop.pNext;
                        }
                        break;
                    }
                    NodeNganh = NodeNganh.pNext;
                }
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (lvDanhSachLop.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lvDanhSachLop.SelectedItems.Count; i++)
                {
                    ListViewItem lv = lvDanhSachLop.SelectedItems[i];
                    if (int.Parse(lv.SubItems[2].Text) > 0)
                    {
                        MessageBox.Show("Số lượng sinh viên trong lớp lớn hơn 0. Không thể xóa lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                DialogResult choose = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (choose == DialogResult.Yes)
                {
                    for (int i = 0; i < lvDanhSachLop.SelectedItems.Count; i++)
                    {
                        ListViewItem lvLH = lvDanhSachLop.SelectedItems[i];
                        Handling_Delete(lvLH.SubItems[0].Text);
                    }
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else return;
            }
            else
            {
                MessageBox.Show("Mời chọn đối tượng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            Show_ListView_Information(tvNganh.SelectedNode.Text);
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
            content += validation.Check_Empty_textbox("Tên lớp", txtTenLop);
            if (content != "")
            {
                MessageBox.Show(content, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            LopHoc lop = new LopHoc();
            lop.MaLopHoc = txtMaLop.Text;
            lop.TenLopHoc = txtTenLop.Text;
            string nganh = Convert.ToString(cbNganh.SelectedItem);
            LinkedListSV<Nganh>.Node NodeN = CSDL_N.pHead;
            while(NodeN.data.TenNganh != nganh )
            {
                NodeN = NodeN.pNext;
            }
            lop.NganhChuQuan = NodeN.data;

            CSDL_LH.AddHead(lop);
            NodeN.data.DsLH.AddHead(lop);

            return true;
        }

        private void Clear()
        {
            txtMaLop.Enabled = true;
            btnThemLop.Enabled = true;
            btnXoaLop.Enabled = true;
            btnSuaLop.Enabled = false;

            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cbNganh.Text = "------Mời chọn ngành------";
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (Check_Add() == true )
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show_ListView_Information(cbNganh.SelectedItem.ToString());
                Clear();
            }

        }

        private void btnXoaThongTinLop_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void lvDanhSachLop_DoubleClick(object sender, EventArgs e)
        {
            btnThemLop.Enabled = false;
            btnXoaLop.Enabled = false;
            btnSuaLop.Enabled = true;
            btnXoaThongTinLop.Enabled = true;

            var index = lvDanhSachLop.FocusedItem.Index;
            var lop = lvDanhSachLop.Items[index];

            txtMaLop.Text = lop.SubItems[0].Text;
            txtTenLop.Text = lop.SubItems[1].Text;
            cbNganh.Text = tvNganh.SelectedNode.Text;
            //Mã lớp k đc thay đổi
            txtMaLop.Enabled = false;
        }

        private void cbNganh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
