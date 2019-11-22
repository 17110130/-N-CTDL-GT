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
using OfficeOpenXml;
using OfficeOpenXml.Style;

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
            Datetime dt = new Datetime(11, 08, 1999);
            sv1.DoB = dt;

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
            Datetime dt2 = new Datetime(10, 10, 2000);
            sv2.DoB = dt2;
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
            quanLyNganhControl1.Get_Data(CSDL_N);
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            timKiemSinhVienControl1.BringToFront();
            lbTitle.Text = "Tìm kiếm sinh viên";
            timKiemSinhVienControl1.Get_data(CSDL_SV, CSDL_LH, CSDL_N);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manHinhChinhControl1.BringToFront();
            lbTitle.Text = "Màn hình chính";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            dialog.ShowDialog();

            filePath = dialog.FileName;


            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "Phần mềm quản lý sinh viên";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Thông kê sinh viên";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Quản lý Sinh Viên");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    // đặt tên cho sheet
                    ws.Name = "Quản lý sinh viên";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 14;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "MSSV",
                                                "Họ tên",
                                                "Giới tính",
                                                "Ngày sinh",
                                                "Điểm toán",
                                                "Điểm lý",
                                                "Điểm hóa",
                                                "Điểm TB",
                                                "Lớp",
                                                "Ngành"
                };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "QUẢN LÝ SINH VIÊN";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // font size
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Size = 25;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    ws.Column(1).Width = 30;
                    ws.Column(2).Width = 30;
                    ws.Column(3).Width = 15;
                    ws.Column(4).Width = 15;
                    ws.Column(5).Width = 15;
                    ws.Column(6).Width = 15;
                    ws.Column(7).Width = 15;
                    ws.Column(8).Width = 15;
                    ws.Column(9).Width = 30;
                    ws.Column(10).Width = 40;

                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);


                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;
                        cell.Value = item;
                        colIndex++;
                    }
                    LinkedListSV<SinhVien>.Node nodeSV = CSDL_SV.pHead;
                    while (nodeSV != null)
                    {
                        colIndex = 1;
                        rowIndex++;
                        ws.Cells[rowIndex, colIndex++].Value = nodeSV.data.Id;
                        ws.Cells[rowIndex, colIndex++].Value = nodeSV.data.Name;
                        string gioiTinh = nodeSV.data.Sex == true ? "Nam" : "Nữ";
                        ws.Cells[rowIndex, colIndex++].Value = gioiTinh;                        
                        ws.Cells[rowIndex, colIndex++].Value = nodeSV.data.DoB.ToDateString();
                        ws.Cells[rowIndex, colIndex++].Value = nodeSV.data.Mscores;
                        ws.Cells[rowIndex, colIndex++].Value = nodeSV.data.Pscores;
                        ws.Cells[rowIndex, colIndex++].Value = nodeSV.data.Cscores;
                        ws.Cells[rowIndex, colIndex++].Value = nodeSV.data.AvgScores();
                        ws.Cells[rowIndex, colIndex++].Value = nodeSV.data.Classmajor.TenLopHoc;
                        ws.Cells[rowIndex, colIndex++].Value = nodeSV.data.Classmajor.NganhChuQuan.TenNganh;
                        nodeSV = nodeSV.pNext;
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất file excel thành công!");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }
        } 
    }
}
