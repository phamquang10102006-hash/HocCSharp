using System;
using System.Collections;

public class Bai15
{
    public class mangsonguyen
    {
        public int []a;
        public int n;
        public void nhap()
        {
            Console.Write("Nhap so luong phan tu: ");
            n=int.Parse( Console.ReadLine());
            a= new int[n];
            for( int i=0; i<n; i++)
            {
                Console.Write($"a[{i}] =");
                a[i]=int.Parse(Console.ReadLine());
            }
        }
        public void xuat()
        {
            Console.WriteLine($"Mang a: ");
            for(int i=0; i<n;i++)
            {
                Console.Write($"{a[i]} ");
            }  
            Console.WriteLine();
        }
        public int max()
        {
            int max= a[0];
            for(int i=1; i<n;i++)
            {
                if( max<a[i])
                max=a[i];
            }
            return max;
        }
        public int min()
        {
            int min= a[0];
            for(int i=1; i<n;i++)
            {
                if( min<a[i])
                min=a[i];
            }
            return min;
        }
        public bool ktsnt(int b)
        {
            if (b==2) return true;
            if(b<2) return false;
            for(int i=2; i<= Math.Sqrt(b); i++)
            {
                if(b%i==0) return false;
            }
            return true;
        }
        public ArrayList nguyento()
        {
            ArrayList bc= new ArrayList();
            for (int i=0; i<n; i++)
            {
                if(ktsnt(a[i]))
                {
                    bc.Add(a[i]);
                }
            }
            return bc;
        }
    }
    public static void run()
    {
        mangsonguyen mn = new mangsonguyen();

        mn.nhap();
        mn.xuat();
        Console.WriteLine($"Gia tri lon nhat: {mn.max()}");
        Console.WriteLine($"Gia tri nhp nhat: {mn.min()}");

        ArrayList newarray = new ArrayList();
        newarray= mn.nguyento();
        Console.Write("Cac so nguyn to: ");
        foreach(int d in newarray)
        {
            Console.Write($"{d} ");
        }
        Console.WriteLine();
    }
}