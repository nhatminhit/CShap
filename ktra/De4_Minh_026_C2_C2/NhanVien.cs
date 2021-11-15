using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De4_Minh_026_C2_C2
{
    class NhanVien
    {
        private string hoten;
        private DateTime ngaytuyen;
        public string HoTen {
            get
            {
                return hoten;
            }
            set
            {
                hoten = value;
            }
        }
        public DateTime NgayTuyen {
            get
            {
                return ngaytuyen;
            }
            set
            {
                ngaytuyen = value;
            }
        }
        public NhanVien() { }
        public NhanVien(string hoTen,DateTime Ngaytuyen)
        {
            this.HoTen = hoTen;
            this.NgayTuyen = Ngaytuyen;
        }
        public override string ToString()
        {
            return string.Format($"{this.HoTen}\t{this.NgayTuyen}");
        }

    }
    class NhanVienBanHang:NhanVien
    {
        private int soluongban;
        public int SLB
        {
            get
            {
                return soluongban;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("So luong ban > 0");
                }
                else
                {
                    soluongban = value;
                }
            }
        }
        public NhanVienBanHang() { }
        public NhanVienBanHang(string hoTen, DateTime Ngaytuyen,int slb) : base(hoTen,Ngaytuyen)
        {
            this.SLB = slb;
        }
        public string TienHH()
        {
            if (SLB < 100)
            {
                return "1000";
            }    
                
            else if (SLB>100 && SLB<500)
            {
                return "2000";
            }    
            else
                return "3000";
        }
        public override string ToString()
        {
            return string.Format($"{this.HoTen}\t{this.NgayTuyen}\t{this.SLB}\t-\t{TienHH()}");
        }
    }

}
