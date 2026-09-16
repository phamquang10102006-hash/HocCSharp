using System;

public class Bai7
{
    static bool kiemtrant(int n)
    {
        if(n<2) return false;
        if(n==2) return true;
        for(int i=2;i<=Math.Sqrt(n); i++)
        {
            if (n%i==0)
            return false;
        }
        return true;
    }
    public static void run()
    {
        Console.Write("Nhap n:");
        int n= int.Parse(Console.ReadLine());

        bool kq= kiemtrant(n);
        if(kq)
        {
            Console.WriteLine($"{n} la so nguyen to");
        }
        else
        {
            Console.WriteLine($"{n} khong phai so nguyen to");
        }
    }
}