using System;

public class Bai12
{
    static void xyly(string a)
    {
        Console.WriteLine($"Chuoi thuong: {a.ToLower()}");
        Console.WriteLine($"Chuoi hoa: {a.ToUpper()}");

        string[] mangchuoi = a.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"So tu trong chuoi la: {mangchuoi.Length}");
    }
    public static void run()
    {
        Console.Write("Nhap mang can xu ly: ");
        string a= Console.ReadLine();

        xyly(a);
        
    }
}