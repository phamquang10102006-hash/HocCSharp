using System;

public class Bai16
{
    public class nguoi
    {
        string []a;
        int n;
        public void nhap()
        {
            Console.Write("nhap so luong nguoi: ");
            n= int.Parse(Console.ReadLine());

            a= new string[n];
            for(int i=0; i<n;i++)
            {
                Console.Write($"Nhap ho ten nguoi {i+1}: ");
                a[i]= Console.ReadLine();
            }
        }
        public void xuat()
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine($"{i+1}. {a[i]}");
            }
        }
        public void sx()
        {
            Array.Sort(a);
        }
    }
    public static void run()
    {  
        nguoi human = new nguoi();
        human.nhap();
        Console.WriteLine("Danh sach truoc khi sap xep");
        human.xuat();
        human.sx();
        Console.WriteLine("Danh sach sau khi sap xep");
        human.xuat();
    }
}