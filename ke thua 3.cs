using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lesson
{
    internal class Menu
    {
        
        static void Main(string[] args)
        {
            TaiKhoan acc1 = new TaiKhoan(500000);
            TaiKhoan acc2 = new TaiKhoanVip(1000000);
            TaiKhoan acc3 = new TaiKhoanTietKiem(1000000);

            List <TaiKhoan> taiKhoans = new List<TaiKhoan>() { acc1, acc2, acc3};

            foreach (TaiKhoan t in taiKhoans)
            {
                t.RutTien(6000000);
            }
        }

    }

    public class TaiKhoan
    {
        public double SoDu { get; set; }
        public TaiKhoan() { }
        public TaiKhoan(double SoDu) { this.SoDu = SoDu; }
        public virtual void RutTien(double soTien)
        {
            if (soTien <= SoDu) { Console.WriteLine("Rút thành công. Số dư còn: " + (SoDu - soTien)); }
            else { Console.WriteLine("Không đủ tiền"); }
        }
    }

    public class TaiKhoanVip : TaiKhoan
    {
        public TaiKhoanVip() { }
        public TaiKhoanVip(double Sodu) : base(Sodu) { }

        public override void RutTien(double soTien)
        {
            if (soTien != SoDu && (SoDu - soTien > -5000001)) { Console.WriteLine("Rút thành công. Số dư còn: " + (SoDu - soTien)); }
            else { Console.WriteLine("Không đủ tiền");
            }
        }
    }

    public class TaiKhoanTietKiem : TaiKhoan
    {
        public TaiKhoanTietKiem() { }
        public TaiKhoanTietKiem(double Sodu) : base(Sodu) { }

        public override void RutTien(double soTien)
        {
            int pdv = 5000;
            if (soTien + pdv <= SoDu) 
            { 
                Console.WriteLine("Rút thành công. Số dư còn: " + (SoDu - soTien - pdv ));
                SoDu -= soTien;
            }
            else { Console.WriteLine("Không đủ tiền"); }
        }
    }

}
