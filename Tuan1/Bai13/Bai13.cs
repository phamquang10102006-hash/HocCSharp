using System;

public class Bai13
{
    public class sinhvien
    {
        public string MaSV;
        public string Ten;
        public string Diachi;
        public string namhoc;
        public void nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV= Console.ReadLine();
            Console.Write("Nhap ten sinh vien: ");
            Ten= Console.ReadLine();
            Console.Write("Nhap dia chi sinh vien: ");
            Diachi= Console.ReadLine();
            Console.Write("Sinh vien nam: ");
            namhoc= Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
            Console.WriteLine($"Ma sinh vien: {MaSV} ");
            Console.WriteLine($"Ten sinh vien: {Ten} ");
            Console.WriteLine($"Dia chi sinh vien: {Diachi} ");
            Console.WriteLine($"La sinh vien nam: {namhoc} ");
        }
    }
    public static void run()
    {
        sinhvien sv = new sinhvien();
        sv.nhap();
        sv.xuat();  
    }
}
