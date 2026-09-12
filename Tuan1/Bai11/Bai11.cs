using System;
using System.ComponentModel;
using System.Text;

public class Bai11
{
    static string daochuoi(string a)
    {
        StringBuilder ab= new StringBuilder();
        for(int i= a.Length-1;i>=0;i--)
        {
            ab.Append(a[i]);
        }
        return ab.ToString();
    }
    public static void run()
    {
        Console.Write("Nhap chuoi can dao: ");
        string a= Console.ReadLine();

        string k=daochuoi(a);
        Console.WriteLine($"Chuoi sau khi dao: {k}");
    }
}
