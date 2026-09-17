using System;
using System.Collections;
using System.ComponentModel;
public class Bai17
{
    public class manghaichieu
    {
        int [,]a;
        int n;
        int m;
        public void nhap()
        {
            Console.Write("Nhap so dong:");
            while(!int.TryParse(Console.ReadLine(), out n) || n<=0)
            {
                Console.WriteLine("n phai la so nguyen duong");
                Console.Write("Nhap so dong:");
            }

            Console.Write("Nhap so cot:");
            while(!int.TryParse(Console.ReadLine(), out m) || m<=0)
            {
                Console.WriteLine("m phai la so nguyen duong");
                Console.Write("Nhap so cot:");
            }
            a= new int[n,m];
            Random chon = new Random();
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    a[i,j]= chon.Next(10,101);
                }
            }
        }
        public void xuat()
        {
            Console.WriteLine("Mang so da tao:");
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        public void chanle(out ArrayList chan, out ArrayList le)
        {
            chan= new ArrayList();
            le=new ArrayList();

            for(int i=0; i<n; i++)
                {
                    for(int j=0; j<m; j++)
                    {
                        if(a[i,j]%2==0)
                        {
                          chan.Add(a[i,j]);  
                        }
                        else
                        {
                           le.Add(a[i,j]); 
                        }
                    }
                    
                }
        }
    }
    public static void run()
    {
        ArrayList chan;
        ArrayList le;
        manghaichieu ad= new manghaichieu();
        ad.nhap();
        ad.xuat();
        ad.chanle(out chan, out le);
        Console.Write("\nMang so chan: ");
        foreach (int adc in chan)
        {
            Console.Write($"{adc} ");
        }
        Console.Write("\nMang so le");
        foreach ( int adl in le)
        {
            Console.Write($"{adl} ");
        }
    }
}