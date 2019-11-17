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
            cbLop.Text = "------Mời chọn lớp------";
            cbNganh.Text = "------Mời chọn ngành------";
            Show_Info_ListViewSV();
            Show_ComboboxNganh();

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

        private void Show_ComboboxNganh()
        {
            cbNganh.Items.Clear();
            LinkedListSV<Nganh>.Node Node = CSDL_N.pHead;
            while( Node != null )
            {
                cbNganh.Items.Add(Node.data.TenNganh);
                Node = Node.pNext;
            }
        }

        private void Show_ComboboxLopHoc(string name)
        {
            cbLop.Items.Clear();
            LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
            while( NodeNganh != null )
            {
                LinkedListSV<LopHoc>.Node NodeLopHoc = NodeNganh.data.DsLH.pHead;
                while( NodeLopHoc != null )
                {
                    if ( NodeNganh.data.TenNganh == name )
                    {
                        cbLop.Items.Add(NodeLopHoc.data.TenLopHoc);
                    }
                    NodeLopHoc = NodeLopHoc.pNext;
                }
                NodeNganh = NodeNganh.pNext;
            }
        }

        private bool Check_Luu()
        {
            string content = "";
            Validation validation = new Validation();
            content += validation.IsDigit("MSSV", txtMSSV);
            if (content == "")
            {
                LinkedListSV<SinhVien>.Node NodeSV = CSDL_SV.pHead;
                while (NodeSV != null)
                {
                    if (NodeSV.data.Id == int.Parse(txtMSSV.Text))
                    {
                        content += "Mã số sinh viên đã tồn tại!\n";
                    }
                    NodeSV = NodeSV.pNext;
                }
            }
            content += validation.IsString("Tên sinh viên", txtTenSinhVien);
            content += validation.Check_radio(radNam, radNu);
            content += validation.Check_Date(txtNgay, txtThang, txtNam);
            content += validation.Check_Combobox("Ngành", cbNganh);
            content += validation.Check_Combobox("Lớp", cbLop);
            content += validation.Check_Diem("Điểm Toán", txtDiemToan);
            content += validation.Check_Diem("Điểm Lý", txtDiemLy);
            content += validation.Check_Diem("Điểm Hóa", txtDiemHoa);

            if (content != "")
            {
                MessageBox.Show(content, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SinhVien sv = new SinhVien();
            sv.Id = int.Parse(txtMSSV.Text);
            sv.Name = txtTenSinhVien.Text;

            bool sex = radNam.Checked ? true : false;
            sv.Sex = sex;

            sv.DoB = new DateTime(int.Parse(txtNam.Text), int.Parse(txtThang.Text), int.Parse(txtNgay.Text));

            sv.Mscores = double.Parse(txtDiemToan.Text);
            sv.Pscores = double.Parse(txtDiemLy.Text);
            sv.Cscores = double.Parse(txtDiemHoa.Text);

            string nganh = this.cbNganh.GetItemText(this.cbNganh.SelectedItem);
            LinkedListSV<Nganh>.Node NodeNganh = CSDL_N.pHead;
            while (NodeNganh != null)
            {
                if (NodeNganh.data.TenNganh == nganh)
                    break;
                NodeNganh = NodeNganh.pNext;
            }

            LinkedListSV<LopHoc>.Node NodeLop = NodeNganh.data.DsLH.pHead;
            string lop = cbLop.GetItemText(cbLop.SelectedItem);
            while (NodeLop != null)
            {
                if (NodeLop.data.TenLopHoc == lop)
                {
                    sv.Classmajor = NodeLop.data;
                    NodeLop.data.DsSV.AddHead(sv);
                    break;
                }
                NodeLop = NodeLop.pNext;
            }

            CSDL_SV.AddHead(sv);
            return true;

        }

        private void Clear()
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;

            txtMSSV.Text = "";
            txtTenSinhVien.Text = "";
            txtNgay.Text = "";
            txtThang.Text = "";
            txtNam.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            cbNganh.Text = "------Mời chọn ngành------";
            cbLop.Text = "------Mời chọn lớp------";
            txtDiemToan.Text = "";
            txtDiemLy.Text = "";
            txtDiemHoa.Text = "";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           if ( Check_Luu() == true )
            {
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show_Info_ListViewSV();
                Clear();
                
            }
        }

        private void Handling_Delete(int mssvDel)
        {
            if (lvThongTinSV.SelectedItems.Count > 0)
            {
                LinkedListSV<SinhVien>.Node NodeSV = CSDL_SV.pHead;
                while (NodeSV != null)
                {
                    if (NodeSV.data.Id == mssvDel)
                    {
                        CSDL_SV.RemoveNode(NodeSV);
                        break;
                    }
                    NodeSV = NodeSV.pNext;
                }

                // XÓa Sinh viên trong lớp học
                LinkedListSV<LopHoc>.Node NodeLop = CSDL_LH.pHead;
                while (NodeLop != null)
                {
                    if (NodeLop.data.MaLopHoc == NodeSV.data.Classmajor.MaLopHoc)
                    {
                        LinkedListSV<SinhVien>.Node NodeSVLop = NodeLop.data.DsSV.pHead;
                        while (NodeSVLop != null)
                        {
                            if (NodeSVLop.data.Id == NodeSV.data.Id)
                            {
                                NodeLop.data.DsSV.RemoveNode(NodeSVLop);
                                break;
                            }
                            NodeSVLop = NodeSVLop.pNext;
                        }
                        break;
                    }
                    NodeLop = NodeLop.pNext;
                }
            }
        }
      
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ( lvThongTinSV.SelectedItems.Count > 0 )
            {
                DialogResult choose = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (choose == DialogResult.Yes)
                {
                    for (int i = 0; i < lvThongTinSV.SelectedItems.Count; i++)
                    {
                        ListViewItem item = lvThongTinSV.SelectedItems[i];
                        Handling_Delete(int.Parse(item.SubItems[0].Text));
                    }
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnXoa.Enabled = true;
                }
                else return;
            }
            Show_Info_ListViewSV();
        }

        private void cbNganh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNganh.SelectedIndex == -1)
                return;
            cbLop.SelectedIndex = -1;
            cbLop.Items.Clear();
            cbLop.Text = "------Mời chọn lớp------";
            string nganh = this.cbNganh.GetItemText(this.cbNganh.SelectedItem);
            Show_ComboboxLopHoc(nganh);
        }

        private void btnXoaThongtin_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void lvThongTinSV_DoubleClick(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;

            var index = lvThongTinSV.FocusedItem.Index;
            var sv = lvThongTinSV.Items[index];

            txtMSSV.Text = sv.SubItems[0].Text;
            txtTenSinhVien.Text = sv.SubItems[1].Text;
            if (sv.SubItems[2].Text == "Nam")
                radNam.Checked = true;
            else radNu.Checked = true;

            var date = sv.SubItems[3].Text.Split('/');
            txtNgay.Text = date[0];
            txtThang.Text = date[1];
            txtNam.Text = date[2];

            txtDiemToan.Text = sv.SubItems[4].Text;
            txtDiemLy.Text = sv.SubItems[5].Text;
            txtDiemHoa.Text = sv.SubItems[6].Text;

            cbNganh.Text = sv.SubItems[9].Text;
            cbLop.Text = sv.SubItems[8].Text;

            // MSSV không đc sửa
            txtMSSV.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // XÓa rồi mới sửa == > thêm vào lại
            Handling_Delete(int.Parse(txtMSSV.Text));
            if ( Check_Luu() )
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show_Info_ListViewSV();
                Clear();               
            }
        }
    }
}
