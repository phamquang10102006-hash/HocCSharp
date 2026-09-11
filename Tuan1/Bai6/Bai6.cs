using System;

public class Bai6
{
    static int timMax(int a, int b, int c)
    {
        int max=a;
        if(b> max)
        {
            max=b;
        }
        if(c>max)
        {
            max=c;
        }
        return max;
    }
    public static void run()
    {
        Console.Write("Nhap so nguyen a: ");
        int a=int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen b: ");
        int b=int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen c: ");
        int c=int.Parse(Console.ReadLine());

        Console.WriteLine("So lon nhat la: "+ timMax(a,b,c));
    }
}