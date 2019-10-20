using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            manHinhChinhControl1.BringToFront();
            lbTitle.Text = "Màn hình chính";
        }
        LinkedList<SinhVien> CSDL_SV = new LinkedList<SinhVien>();
        LinkedList<LopHoc> CSDL_LH = new LinkedList<LopHoc>();
        LinkedList<Nganh> CSDL_N = new LinkedList<Nganh>();

        private void taoDuLieu()
        {
            Nganh cntt = new Nganh();
            cntt.MaNganh = "CNTT";
            cntt.TenNganh = "Công nghệ thông tin";

            LopHoc cl1 = new LopHoc();
            cl1.MaLopHoc = "CNTT_1711";
            cl1.TenLopHoc = "171101LC1";

            SinhVien sv1 = new SinhVien();
            sv1.Id = 17110101;
            sv1.Name = "Nguyễn Văn A";
            sv1.Sex = true;

            cntt.DsLH.AddFirst(cl1);
            cl1.DsSV.AddFirst(sv1);

            CSDL_SV.AddFirst(sv1);
            CSDL_LH.AddFirst(cl1);
            CSDL_N.AddFirst(cntt);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            quanLySinhVienControl1.BringToFront();
            lbTitle.Text = "Quản lý sinh viên";
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            quanLyLopHocControl1.BringToFront();
            lbTitle.Text = "Quản lý lớp học";
        }

        private void btnQLN_Click(object sender, EventArgs e)
        {
            quanLyNganhControl1.BringToFront();
            lbTitle.Text = "Quản lý  ngành";
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            timKiemSinhVienControl1.BringToFront();
            lbTitle.Text = "Tìm kiếm sinh viên";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manHinhChinhControl1.BringToFront();
            lbTitle.Text = "Màn hình chính";
        }
    }
}
