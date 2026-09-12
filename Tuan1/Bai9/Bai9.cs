using System;
using System.Runtime.CompilerServices;

public class Bai9
{
    static void maxmin(double a, double b, double c, out double max, out double min)
    {
        min=a;
        max=a;
        if(b>max)
        {
            max=b;
        }
        else
        {
            min=b;
        }
        if(c>max)
        {
            max=c;
        }
        if(c<min)
        {
            min=c;
        }
    }
    public static void run()
    {
        Console.Write($"Nhap so thuc thu nhat: ");
        double x= double.Parse(Console.ReadLine());

        Console.Write($"Nhap so thuc thu hai: ");
        double y= double.Parse(Console.ReadLine());

        Console.Write($"Nhap so thuc thu ba: ");
        double z= double.Parse(Console.ReadLine());

        double max,min;
        maxmin(x,y,z, out max, out min);

        Console.WriteLine($"so thuc lon nhat la: {max}");
        Console.WriteLine($"so thuc nho nhat la: {min}");
    }
}