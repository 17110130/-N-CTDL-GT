using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class SinhVien
    {
        private int id;
        private string name;
        private bool sex;
        private Datetime doB; // ngày sinh
        private LopHoc classmajor; // Lớp chủ quản chính
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

        public Datetime DoB
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

        public LopHoc Classmajor
        {
            get { return classmajor; }
            set { classmajor = value; }
        }

        public double AvgScores()
        {
            return ((Mscores + Pscores + Cscores) / 3);
        }
    }
}

