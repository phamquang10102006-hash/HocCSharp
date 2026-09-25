using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Bai01
{
    public class sinhvien
    {
        private string ten;
        private int namsinh;

        public sinhvien()
        {
            ten= "";
            namsinh=0;
        }

        public string name
        {
            get { return ten; }
            set { ten= value; }
        }

        public int year
        {
            get{ return namsinh;}
            set{namsinh=value;}
        }

        public void nhap()
        {
            Console.Write("Nhap ho ten: ");
            ten= Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namsinh= int.Parse(Console.ReadLine());
        }
        public int tinhtuoi()
        {
            return DateTime.Now.Year - namsinh;
        }
        public void xuat()
        {
            Console.WriteLine($"Ho ten: {ten}");
            Console.WriteLine($"Nam sinh: {namsinh}");
            Console.WriteLine($"Tuoi: {tinhtuoi()}");
        }
    }
    public static void run()
    {
        sinhvien sv= new sinhvien();

        sv.nhap();
        sv.xuat();
    }
}