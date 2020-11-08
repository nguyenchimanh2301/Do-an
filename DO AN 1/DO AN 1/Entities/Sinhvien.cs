using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.Presenation
{
    class Sinhvien
    {
        private string mahs;
        private string tenhs;
        private string tenlop;
        private string diachi;
        private string sdt;

        public string Mahs 
        { get => mahs; 
            set => mahs = value; }
        public string Tenhs 
        { get => tenhs; 
            set => tenhs = value; }
        public string Tenlop 
        { get => tenlop; 
            set => tenlop = value; }
        public string Diachi 
        { get => diachi;
            set => diachi = value; }
        public string Sdt 
        { get => sdt; 
            set => sdt = value; }
        public Sinhvien(Sinhvien hs)
        {
            this.mahs = hs.mahs;
            this.tenhs = hs.tenhs;
            this.tenlop = hs.tenlop;
            this.diachi = hs.diachi;
            this.sdt = hs.sdt;
        }
        public Sinhvien(string mahs,string tenhs,string diachi,string tenlop,string sdt)
        {
            this.mahs = mahs;
            this.tenhs = tenhs;
            this.tenlop = tenlop;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}
