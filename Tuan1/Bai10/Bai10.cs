using System;

public class Bai10
{
    static bool doixungchuoi(string a)
    {
        for(int i=0; i<a.Length/2; i++)
        {
            if(a[i]!= a[a.Length-i-1]) return false;
        }
        return true;
    }
    public static void run()
    {
        Console.Write("Nhap chuoi can kiem tra: ");
        string a= Console.ReadLine();

        if(doixungchuoi(a))
        {
            Console.WriteLine($"Chuoi doi xung");
        }
        else
        {
            Console.WriteLine($"Chuoi khong doi xung");
        }
    }
}