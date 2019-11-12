using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{ 
    public class Validation
    {
        public string Check_Empty_textbox_(string s,TextBox txt)
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
    }
}
