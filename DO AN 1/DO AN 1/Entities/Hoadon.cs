using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.Entities
{
    class Hoadon
    {
        private double tienphong;
        private double tiennuoc;
        private double tienvesinh;
        private int tgiano;
        private double tkhac;
        private double tiendien;

        public double Tienphong { get => tienphong; set => tienphong = value; }
        public double Tienvesinh { get => tienvesinh; set => tienvesinh = value; }
        public int Tgiano { get => tgiano; set => tgiano = value; }
        public double Tkhac { get => tkhac; set => tkhac = value; }
        public double Tiennuoc { get => tiennuoc; set => tiennuoc = value; }
        public double Tiendien { get => tiendien; set => tiendien = value; }

        public Hoadon(Hoadon d)
        {
            this.tienphong = d.tienphong;
            this.tienvesinh = d.tienvesinh;
            this.tkhac = d.tkhac;
            this.tgiano = d.tgiano;
            this.tiennuoc = d.tiennuoc;
            this.tiendien = d.tiendien;
        }
        public Hoadon(double tienphong,double tiendien,double tiennuoc,double tienvesinh,int tgiano,double tkhac)
        {
            this.tienphong = tienphong;
            this.tienvesinh = tienvesinh;
            this.tkhac = tkhac;
            this.tgiano = tgiano;
            this.tiendien = tiendien;
            this.tiennuoc = tiennuoc;
        }
    }

}
