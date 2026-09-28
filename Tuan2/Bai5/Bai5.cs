using System;
public class Bai05
{
    public class donthuc
    {
        private double a;
        private int n;

        public donthuc()
        {
            a=0;
            n=0;
        }
        public donthuc(donthuc other)
        {
            a=other.a;
            n=other.n;
        }
        public donthuc(double a, int n)
        {
            if(n<0)
            throw new ArgumentException("So mu phai >=0!");

            this.a=a;
            this.n=n;
        }
        public double A
        {
            get{return a;}
            set{a=value;}
        }
        public int N
        {
            get{return n;}
            set
            {
                if(value <0)
                throw new ArgumentException("So mu phai >= 0!");

                n=value;
            }
        }
         public void nhap()
        {
            Console.Write("Nhap he so a: ");
            a = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhap so mu n >= 0: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0);
        }
        public void xuat()
        {
             Console.WriteLine(ToString());
        }
        public double tinh(double x)
        {
            return a* Math.Pow(x,n);
        }
        public donthuc daoham()
        {
            if(n==0) return new donthuc(0,0);
            return new donthuc(a*n,n-1);
        }
        public override string ToString()
        {
            if(n==0)
            return a.ToString();
            if(n==1)
            return a + "X";
            return a + "X^" + n;
        }
    }
    public static void run()
    {
        donthuc p = new donthuc();

        p.nhap();

        Console.WriteLine("\nDon thuc:");
        p.xuat();

        Console.Write("Nhap x: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("P(" + x + ") = " + p.tinh(x));

        donthuc derivative = p.daoham();

        Console.WriteLine("Dao ham: " + derivative);
    }
}