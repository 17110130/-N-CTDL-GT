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
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            quanLyLopHocControl1.BringToFront();
        }

        private void btnQLN_Click(object sender, EventArgs e)
        {
            quanLyNganhControl1.BringToFront();
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            timKiemSinhVienControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manHinhChinhControl1.BringToFront();
        }
    }
}
