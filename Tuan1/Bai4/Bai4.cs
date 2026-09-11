using System;

public class Bai4
{
    public static void run()
    {
        int x,y;
        //kiem tra x co phai so nguyen khong
        while (true)
        {
            Console.Write("Nhap so nguyen x: ");
            //ep gia tri vua nhap vao x neu duoc thi x nguyen
            if( int.TryParse(Console.ReadLine(), out x))
            {
                break;
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so nguyen!");
            }
        }
        //kiem tra y
        while(true)
        {
            Console.Write("Nhap so nguyen y: ");
            //thu ep nhu x
            if(int.TryParse(Console.ReadLine(), out y))
            {
                break;
            }
            else
            {
                Console.WriteLine("vui long nhap mot so nguyen!");
            }
        }
         long kq=1;
        for(int i=0; i< y; i++)
        {
            kq *=x;
        }
        Console.Write("Ket qua "+x+ " mu "+y+" la: "+kq);
    }
}