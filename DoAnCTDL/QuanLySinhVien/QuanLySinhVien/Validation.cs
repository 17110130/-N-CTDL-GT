using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{ 
    public class Validation
    {
        public string Check_Empty_textbox(string s,TextBox txt)
        {
            if (txt.Text == "")
                return s + " Không được để trống!";
            return "";
        }

        public string Check_Select_Combobox(string s,ComboBox cb)
        {
            if (cb.SelectedIndex == -1)
                return "Hãy chọn " + s + "\n";
            return "";
        }

        public string IsDigit(string name,TextBox txt)
        {
            string content = Check_Empty_textbox(name, txt);
            if (content != "")
                return content;
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(txt.Text))
            {
                return name + " phải là SỐ\n";
            }
            return "";
        }

        public string IsString(string name,TextBox txt)
        {
            string content = Check_Empty_textbox("Tên sinh viên", txt);
            if ( content != "" )
            {
                return content;
            }
            Regex regex = new Regex(@"\d+");
            if (!regex.IsMatch(txt.Text))
            {
                return "";
            }
            return name + " phải là CHUỖI\n";
        }

        public string Check_radio(RadioButton rad1,RadioButton rad2)
        {
            if (rad1.Checked == false && rad2.Checked == false)
                return "Hãy chọn giới tính!\n";
            return "";
        }

        public string Check_Date(TextBox txtDay,TextBox txtMonth,TextBox txtYear)
        {
            string content = "";
            content += Check_Empty_textbox("Ngày sinh", txtDay);
            content += Check_Empty_textbox("Tháng sinh", txtMonth);
            content += Check_Empty_textbox("Năm sinh", txtYear);
            if (content != "")
                return content;

            if (int.Parse(txtMonth.Text) < 1 || int.Parse(txtMonth.Text) > 12)
                return "Tháng sinh không hợp lệ\n";
            if (int.Parse(txtYear.Text) > DateTime.Now.Year)
                return "Năm sinh không hợp lệ\n";

            int[] arrDay = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (int.Parse(txtMonth.Text) == 2 && int.Parse(txtYear.Text) % 400 == 0 || (int.Parse(txtYear.Text) % 4 == 0
                && int.Parse(txtYear.Text) % 100 != 0))
                return "";

            if (int.Parse(txtDay.Text) < 1 || int.Parse(txtDay.Text) > arrDay[int.Parse(txtMonth.Text)])
                return "Ngày sinh không hợp lệ\n";

            return "";

        }

        public string Check_Combobox(string name,ComboBox cb)
        {
            if ( cb.SelectedIndex == -1 )
                return "Hãy chọn " + name + "\n";
            return "";
        }

        public string Check_Diem(string name,TextBox txt)
        {
            string content = Check_Empty_textbox(name, txt);
            if (content != "")
                return content;
            if (double.Parse(txt.Text) < 0 || double.Parse(txt.Text) > 10)
                return name + " không hợp lệ!\n";
            return "";
        }
    }
}
