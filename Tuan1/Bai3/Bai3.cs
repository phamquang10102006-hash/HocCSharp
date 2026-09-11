using System;

public class Bai3
{
    public static void run()
    {
        //nhap x
        Console.Write("Nhap so nguyen x: ");
        int x = int.Parse(Console.ReadLine());
        //Nhap y
        Console.Write("Nhap so nguyen y: ");
        int y= int.Parse(Console.ReadLine());
         long kq=1;
        for(int i=0; i<y; i++)
        {
            kq *=x;
        }
        Console.Write("Ket qua "+x+ " mu "+y+" la: "+kq);
    }
}