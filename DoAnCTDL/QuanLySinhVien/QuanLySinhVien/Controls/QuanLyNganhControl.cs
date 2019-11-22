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
    public partial class QuanLyNganhControl : UserControl
    {
        public QuanLyNganhControl()
        {
            InitializeComponent();
        }

        private LinkedListSV<Nganh> CSDL_N = new LinkedListSV<Nganh>();

        internal void Get_Data(LinkedListSV<Nganh> CSDL_N)
        {
           
            this.CSDL_N = CSDL_N;

            Show_Infor_ListBox();
        }

        private void Show_Infor_ListBox()
        {
            lvThongTinNganh.Items.Clear();

            LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
            while ( NodeNganh != null )
            {

                ListViewItem lvNganh = new ListViewItem(NodeNganh.data.MaNganh);
                lvNganh.SubItems.Add(NodeNganh.data.TenNganh);
                lvNganh.SubItems.Add(NodeNganh.data.DsLH.count.ToString());

                lvThongTinNganh.Items.Add(lvNganh);
                NodeNganh = NodeNganh.pNext;
            }
        }

        private void Clear()
        {
            btnAddNganh.Enabled = true;
            btnSuaNganh.Enabled = false;
            btnXoaNganh.Enabled = true;

            txtMaNganh.Text = "";
            txtTenNganh.Text = "";
            txtMaNganh.Enabled = true;
        }

        private void btnXoaThongTinNganh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool Check_Save()
        {
            string content = "";
            Validation validation = new Validation();
            content += validation.Check_Empty_textbox("Mã ngành", txtMaNganh);
            if ( content == "")
            {
                LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
                while( NodeNganh != null )
                {
                    if ( NodeNganh.data.MaNganh == txtMaNganh.Text )
                    {
                        content += "Mã ngành đã tồn tại!\n";
                        txtMaNganh.Text = "";
                        break;
                    }
                    NodeNganh = NodeNganh.pNext;
                }
            }
            content += validation.Check_Empty_textbox("Tên ngành", txtTenNganh);
            if (content == "" )
            {
                LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
                while( NodeNganh != null )
                {
                    if ( NodeNganh.data.TenNganh == txtTenNganh.Text )
                    {
                        content += "Tên ngành đã tồn tại\n";
                        txtTenNganh.Text = "";
                        break;
                    }
                    NodeNganh = NodeNganh.pNext;
                }
            
            }
            if ( content != "" )
            {
                MessageBox.Show(content, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Nganh Nganh = new Nganh();
            Nganh.MaNganh = txtMaNganh.Text;
            Nganh.TenNganh = txtTenNganh.Text;

            CSDL_N.AddHead(Nganh);
            return true;
        }

        private void btnAddNganh_Click(object sender, EventArgs e)
        {
            if ( Check_Save() == true )
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show_Infor_ListBox();
                Clear();
            }
        }

        private void lvThongTinNganh_DoubleClick(object sender, EventArgs e)
        {
            btnAddNganh.Enabled = false;
            btnXoaNganh.Enabled = false;
            btnSuaNganh.Enabled = true;

            var index = lvThongTinNganh.FocusedItem.Index;
            var nganh = lvThongTinNganh.Items[index];

            txtMaNganh.Text = nganh.SubItems[0].Text;
            txtTenNganh.Text = nganh.SubItems[1].Text;

            txtMaNganh.Enabled = false;

        }

        private void btnSuaNganh_Click(object sender, EventArgs e)
        {
            LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
            while( NodeNganh != null )
            {
                if ( NodeNganh.data.MaNganh == txtMaNganh.Text )
                {
                    NodeNganh.data.TenNganh = txtTenNganh.Text;
                    break;
                }
                NodeNganh = NodeNganh.pNext;
            }
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show_Infor_ListBox();
            Clear();

        }

        private void Handling_Delete(string manganhDel)
        {
            LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
            while(NodeNganh != null )
            {
                if ( NodeNganh.data.MaNganh == manganhDel )
                {
                    CSDL_N.RemoveNode(NodeNganh);
                    break;
                }
                NodeNganh = NodeNganh.pNext;
            }
        }

        private void btnXoaNganh_Click(object sender, EventArgs e)
        {
            if (lvThongTinNganh.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lvThongTinNganh.SelectedItems.Count; i++)
                {
                    ListViewItem lv = lvThongTinNganh.SelectedItems[i];
                    if (int.Parse(lv.SubItems[2].Text) > 0)
                    {
                        MessageBox.Show("Số lượng lớp trong ngành lớn hơn 0. Không thể xóa ngành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                DialogResult choose = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (choose == DialogResult.Yes)
                {
                    for (int i = 0; i < lvThongTinNganh.SelectedItems.Count; i++)
                    {
                        ListViewItem item = lvThongTinNganh.SelectedItems[i];
                        Handling_Delete(item.SubItems[0].Text);
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
            Show_Infor_ListBox();
        }
    }
}
