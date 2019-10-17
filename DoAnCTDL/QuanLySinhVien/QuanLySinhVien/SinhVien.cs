using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVien
    {
        private int id;
        private string name;
        private bool sex;
        private DateTime doB; // ngày sinh
        private double mScores; // điểm toán
        private double pScores; // điểm lý
        private double cScores; // điểm hóa

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public DateTime DoB
        {
            get { return doB; }
            set { doB = value; }
        }

        public double Mscores
        {
            get { return mScores; }
            set { mScores = value; }
        }

        public double Pscores
        {
            get { return pScores; }
            set { pScores = value; }
        }

        public double Cscores
        {
            get { return cScores; }
            set { cScores = value; }
        }

        public double AvgScores()
        {
            return ((Mscores + Pscores + Cscores) / 3);
        }
    }
}

