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
            NhanVien Thanh = new NhanVienFullTime("Thanh", 10000000);
            NhanVien Tai = new NhanVienPartTime("Tai", 20, 50000);

            Thanh.XuatThongTin();
            Tai.XuatThongTin();
        }

        public class NhanVien
        {
            public string Name { get; set; }
            public NhanVien() { }
            public NhanVien(string name) { this.Name = name; }
            public virtual double TinhLuong() { return 0; }
            public void XuatThongTin()
            {
                Console.WriteLine(this.Name);
                Console.WriteLine(this.TinhLuong());
            }


        }

        public class NhanVienFullTime : NhanVien
        {
            public double LuongCung { get; set; }
            public NhanVienFullTime(string name, double money) : base(name) 
            { 
                this.LuongCung = money;
            }
            

            public override double TinhLuong() 
            { 
                return LuongCung;
            }
        }

        public class NhanVienPartTime : NhanVien
        {
            public int SoGioLam { get; set; }
            public double LuongTheoGio { get; set; }
            public NhanVienPartTime(string name, int time, double money) : base(name) 
            {
                this.SoGioLam = time;
                this.LuongTheoGio = money;
            }


            public override double TinhLuong()
            {
                return SoGioLam * LuongTheoGio;
            }
        }

    }
    
    
}
