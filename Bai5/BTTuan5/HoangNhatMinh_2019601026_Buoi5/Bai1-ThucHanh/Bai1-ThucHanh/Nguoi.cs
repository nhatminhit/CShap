using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_ThucHanh
{
    class Nguoi
    {
        protected string HoTen { get; set; }
        protected string GioiTinh { get; set; }
        protected int NamSinh { get; set; }
        protected string DC { get; set; }
        public Nguoi()
        {

        }
        public Nguoi(string ht, string gt, int ns,string dc)
        {
            this.HoTen = ht;
            this.GioiTinh = gt;
            this.NamSinh = ns;
            this.DC = dc;
        }
        public virtual void Output()
        {
            Console.Write($"\t{this.HoTen} \t{this.GioiTinh} \t{this.NamSinh}\t{this.DC}");
        }
    }
}

