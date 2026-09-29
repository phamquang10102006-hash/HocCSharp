using System;
using System.Collections;
using System.Drawing;

public class Bai06
{
    public class arraypoint
    {
        private ArrayList list;
        public arraypoint()
        {
            list = new ArrayList();
        }
        public arraypoint(int n)
        {
            list = new ArrayList();
            for(int i=0; i<n; i++)
            {
                list.Add(new Bai02.point());
            }
        }
         public arraypoint(arraypoint other)
        {
            list = new ArrayList();

            for (int i = 0; i < other.list.Count; i++)
            {
                Bai02.point p = (Bai02.point)other.list[i];

                list.Add(new Bai02.point(p.xxx,p.yyy));
            }
        }

         public int Count
        {
            get { return list.Count; }
        }

    // Indexer
    public Bai02.point this[int index]
    {
        get
        {
            return (Bai02.point)list[index];
        }

        set
        {
            list[index] = value;
        }
    }

    // Thêm Point
    public void Add(Bai02.point p)
    {
        list.Add(p);
    }

    // Nhập
    public void Input()
    {
        Console.Write("Nhap so luong Point: ");
        int n = int.Parse(Console.ReadLine());

        list.Clear();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap Point thu " + i + ":");

            Bai02.point p = new Bai02.point();
            p.nhap();

            list.Add(p);
        }
    }

    // Xuất
    public void Output()
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("Point " + i + ": " + list[i]);
        }
    }

    
    }

    public static void run()
    {
        arraypoint ds = new arraypoint();

        ds.Add(new Bai02.point(1, 2));
        ds.Add(new Bai02.point(3, 4));

        Console.WriteLine(ds[0]);
        Console.WriteLine(ds[1]);
    }
}