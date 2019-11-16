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
            taoDuLieu();
        }
        public static LinkedListSV<SinhVien> CSDL_SV = new LinkedListSV<SinhVien>();
        public static LinkedListSV<LopHoc> CSDL_LH = new LinkedListSV<LopHoc>();
        public static LinkedListSV<Nganh> CSDL_N = new LinkedListSV<Nganh>();

        private void taoDuLieu()
        {
            Nganh cntt = new Nganh();
            cntt.MaNganh = "CNTT";
            cntt.TenNganh = "Công nghệ thông tin";

            LopHoc cl1 = new LopHoc();
            cl1.MaLopHoc = "CNTT_1711";
            cl1.TenLopHoc = "171101LC1";
            cl1.NganhChuQuan = cntt;

            SinhVien sv1 = new SinhVien();
            sv1.Id = 17110101;
            sv1.Name = "Nguyễn Văn A";
            sv1.Sex = true;
            sv1.Classmajor = cl1;

            cntt.DsLH.AddHead(cl1);
            cl1.DsSV.AddHead(sv1);
            CSDL_SV.AddHead(sv1);
            CSDL_LH.AddHead(cl1);
            CSDL_N.AddHead(cntt);

            Nganh kinhte = new Nganh();
            kinhte.MaNganh = "KT";
            kinhte.TenNganh = "Kinh tế";

            LopHoc kt1 = new LopHoc();
            kt1.MaLopHoc = "KT_1722";
            kt1.TenLopHoc = "17220130CL2";
            kt1.NganhChuQuan = kinhte;

            SinhVien sv2 = new SinhVien();
            sv2.Id = 17220130;
            sv2.Name = "Nguyễn Thị B";
            sv2.Sex = false;
            sv2.Classmajor = kt1;

            kinhte.DsLH.AddHead(kt1);
            kt1.DsSV.AddHead(sv2);
            CSDL_SV.AddHead(sv2);
            CSDL_LH.AddHead(kt1);
            CSDL_N.AddHead(kinhte);
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
            quanLySinhVienControl1.Get_Data(CSDL_SV, CSDL_LH, CSDL_N);
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            quanLyLopHocControl1.BringToFront();
            lbTitle.Text = "Quản lý lớp học";
            quanLyLopHocControl1.Get_Data(CSDL_LH, CSDL_N);
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
