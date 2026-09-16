using System;
using System.Data;

public class Bai14
{
    public class luong
    {
        public string hoten;
        public int mucluong;
        public int vang;
        public void nhap()
        {
            Console.WriteLine("---Nhap thong tin---");
            Console.Write("ho Ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap muc luong: ");
            mucluong =int.Parse(Console.ReadLine());
            Console.Write("So ngay vang: ");
            vang= int.Parse(Console.ReadLine());
        }
        public int tinhluong()
        {
            return mucluong -(vang*100000);
        }
        public void xuat()
        {
            Console.WriteLine("---Luong nhan vien---");
            Console.WriteLine($"Ho ten: {hoten}");
            Console.WriteLine($"muc luong co ban: {mucluong}");
            Console.WriteLine($"So ngay vang: {vang}");
            Console.WriteLine($"luong nhan duoc: {tinhluong()}");
        }

    }
    public static void run()
    {
        luong l= new luong();
        l.nhap();
        l.xuat();
    }
}