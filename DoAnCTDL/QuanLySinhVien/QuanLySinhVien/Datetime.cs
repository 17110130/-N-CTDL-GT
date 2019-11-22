using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Datetime
    {
        public int day;
        public int month;
        public int year;

        public Datetime(int theDay, int theMonth, int theYear)
        {
            if (theMonth > 0 && theMonth <= 12)
                month = theMonth;
            else
            {
                month = 1; // Tháng k hợp lệ. Tạm thời gán month =1
            }
            year = theYear;
            day = CheckDay(theDay);
        }
        private int CheckDay(int theDay)
        {
            int[] arrDay = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (theDay > 0 && theDay <= arrDay[month])
                return theDay;
            if (month == 2 && theDay == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
                return theDay;
            return 1;
        }
        public string ToDateString()
        {
            return day + "/" + month + "/" + year;
        }

        
    }
}
