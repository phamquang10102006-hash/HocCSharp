using System;
using System.Collections;
public class Bai07
{
    public class PersonList
    {
        private ArrayList list;
        public PersonList()
        {
            list = new ArrayList();
        }
        public PersonList(PersonList other)
        {
            list = new ArrayList();

            for (int i = 0; i < other.list.Count; i++)
            {
                Bai03.nguoi p = (Bai03.nguoi)other.list[i];

                list.Add(new Bai03.nguoi(p));
            }
        }
        public int Count
        {
            get{ return list.Count;}
        }
        public Bai03.nguoi this[int index]
        {
            get
            {
                return (Bai03.nguoi)list[index];
            }

            set
            {
                list[index] = value;
            }
        }

        public void Add(Bai03.nguoi p)
        {
            list.Add(p);
        }
        public void nhap()
        {
         Console.Write("Nhap so luong nguoi: ");
        int n = int.Parse(Console.ReadLine());

        list.Clear();
        
        for(int i=0; i<n; i++)
            {
                Bai03.nguoi pe = new Bai03.nguoi();
                Console.WriteLine("\nNhap nguoi thu " + i + ":");
                pe.nhap();
                list.Add(pe);
            }
        }
        public void xuat()
        {
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine("\nNguoi thu " + i + ":");
                list[i].ToString();
                ((Bai03.nguoi)list[i]).xuat();
            }
        }
        public PersonList nguoiconsong()
        {
            PersonList pel = new PersonList();
            for(int i=0; i<list.Count; i++)
            {
                Bai03.nguoi pe = (Bai03.nguoi)list[i];

                if( pe.tontai())
                {
                    pel.Add(new Bai03.nguoi(pe));
                }
            }
            return pel;

        }

    }
    public static void run()
    {
        PersonList ds = new PersonList();

        ds.nhap();

        Console.WriteLine("\n===== DANH SACH =====");
        ds.xuat();

        PersonList living = ds.nguoiconsong();

        Console.WriteLine("\n===== NGUOI CON SONG =====");
        living.xuat();
    }
}