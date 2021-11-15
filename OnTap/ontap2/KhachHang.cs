using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap2
{
    class KhachHang
    {
        private string hoTen;
        private bool gioiTinh;
        private int sLMua;
        private double donGia;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int SLMua { get => sLMua; set => sLMua = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public KhachHang() { }
        public KhachHang(string hoten, bool gioitinh, int sl, double gia)
        {
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.SLMua = sl;
            this.DonGia = gia;
        }
        public string convert1()
        {
            if (this.GioiTinh == true)
            {
                return "Nam".ToUpper(); ;
            }
            else
            {
                return "Nu".ToUpper(); ;
            }
        }
        public double tinh()
        {
            if (this.SLMua < 100)
                return this.SLMua * this.DonGia;
            else
            {
                return 0.9 * (this.SLMua * this.DonGia);
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}", this.HoTen, convert1(), this.SLMua, this.DonGia, tinh());
        }
    }
    class KhachHangThanThiet : KhachHang
    {
        private string quaTang;
        public string QuaTang { get => quaTang; set => quaTang = value; }
        public KhachHangThanThiet() { }
        public KhachHangThanThiet(string hoten, bool gioitinh, int sl, double gia) : base(hoten, gioitinh, sl, gia)
        {

        }
        public string XDQuaTang()
        {
            if (tinh() <= 1000)
                return "Coupon 200";
            else
                return "Coupon 500";
        }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", this.HoTen, convert1(), this.SLMua, this.DonGia, tinh(), XDQuaTang());
        }
    }

}

