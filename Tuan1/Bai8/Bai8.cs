using System;

public class Bai8
{
    static void hoanvi(ref double x, ref double y)
    {
        double stamp=x;
        x=y;
        y=stamp;
    }
    public static void run()
    {
        Console.Write("Nhap so thu nhat: ");
        double x= double.Parse(Console.ReadLine());
         Console.Write("Nhap so thu hai: ");
        double y= double.Parse(Console.ReadLine());
        Console.WriteLine($"so thu nhat ban dau: {x}");
        Console.WriteLine($"so thu hai ban dau: {y}");
        hoanvi(ref x, ref y);
        Console.WriteLine($"so thu nhat sau hoan vi: {x}");
        Console.WriteLine($"so thu hai sau hoan vi: {y}");

    }
}