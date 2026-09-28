using System;
public class Bai03
{
   public class nguoi
    {
         private string id;
        private string name;
        private int yob;
        private int yod;

        public nguoi()
            {
                id="";
                name="";
                yob=0;
                yod=0;
            }
        public  nguoi(nguoi other)
        {
            id=other.id;
            name=other.name;
            yob=other.yob;
            yod=other.yod;
        }  
        public nguoi(string id, string name, int yob, int yod)
        {
            this.id=id;
            this.name=name;
            this.yob=yob;
            this.yod=yod;
        }
        public string Id
        {
            get{ return id; }
            set{id=value; }
        }
        public string Name
        {
            get{return name;}
            set{name=value;}
        }
        public int Yob
        {
            get{return yob; }
            set{yob=value; }
        }
        public int Yod
        {
            get{return yod;}
            set{yod=value; }
        }
        public void nhap()
        {
            Console.Write("Nhap id: ");
            id=Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            name=Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            yob= int.Parse(Console.ReadLine());
            Console.Write("Nhap nam mat(neu chua mat nhap 0): ");
            yod=int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("------Thong tin--------");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Ho ten: {name}");
            Console.WriteLine($"Nam sinh: {yob}");
            Console.WriteLine($"Nam mat: {yod}");
        }
        public bool tontai()
        {
            return yod == 0;
        }
    }
    public static void run()
    {
        nguoi ng= new nguoi();
        ng.nhap();
        ng.xuat();
        if(ng.tontai())
        Console.WriteLine("Nguoi nay con song.");
        else
        Console.WriteLine("Nguoi nay da mat.");
    }


}