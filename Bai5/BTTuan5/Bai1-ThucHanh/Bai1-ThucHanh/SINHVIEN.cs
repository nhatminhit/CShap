using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_ThucHanh
{
    class SINHVIEN : Nguoi
    {
        protected double TX { get; set; }
        protected double DT { get; set; }
        public double diemtong()
        {
            return (this.TX*0.3) + (this.DT*0.7);
        }
        public SINHVIEN() : base()
        {

        }
        public SINHVIEN(string ht, string gt, int ns, string dc, double tx, double dt) : base(ht, gt, ns, dc)
        {
            this.TX = tx;
            this.DT = dt;
        }
        public override void Output()
        {
            base.Output();
            Console.Write($" \t{this.TX} \t{this.DT} \t{this.diemtong()}");
        }
    }
}
