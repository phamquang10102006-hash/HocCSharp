using System;

public class Bai02
{
    public class point
    {
        private double x;
        private double y;

        public point()
        {
            x=0;y=0;
        }
        public point(double x, double y)
        {
            this.x=x;
            this.y=y;
        }

        public double xxx
        {
            get {return x;}
            set {x=value;}
        }
        public double yyy
        {
            get {return y;}
            set {y=value; }
        }
        public void nhap()
        {
            Console.Write("Nhap x: ");
            x= double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y= double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
              Console.WriteLine("(" + x + ", " + y + ")");
        }
         public override string ToString()
            {
                return "(" + x + ", " + y + ")";
            }
        public static point operator +(point a, point b)
        {
            return new point(a.x +b.x, a.y+b.y);
        }    
        public static point operator -(point a, point b)
        {
            return new point(a.x -b.x, a.y-b.y);
        } 
        public static point operator -(point a)
        {
            return new point(-a.x, -a.y);
        }   

        //khoangcach
        public double kc(point other)
        {
            double dx = other.x - this.x;
            double dy = other.y - this.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static double kc(point a, point b)
        {
            double dx = b.x - a.x;
            double dy = b.y - a.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
        //trungdiem
        public point td(point other)
        {
            return new point(
                (this.x + other.x) / 2,
                (this.y + other.y) / 2
            );
        }
        public static point td(point a, point b)
        {
            return new point(
                (a.x + b.x) / 2,
                (a.y + b.y) / 2
            );
        }

    }
    public static void run()
    {
        point A = new point();
        point B = new point();

        Console.WriteLine("Nhap diem A:");
        A.nhap();

        Console.WriteLine("Nhap diem B:");
        B.nhap();

        Console.WriteLine("\nA = " + A);
        Console.WriteLine("B = " + B);

        // Operator
        point C = A + B;
        point D = A - B;
        point E = -A;

        Console.WriteLine("\nA + B = " + C);
        Console.WriteLine("A - B = " + D);
        Console.WriteLine("-A = " + E);

        // Khoang cach
        Console.WriteLine("\nKhoang cach A-B:");

        Console.WriteLine(
            "Thanh vien: " + A.kc(B)
        );

        Console.WriteLine(
            "Tinh: " + point.kc(A, B)
        );

        // Trung diem
        point I1 = A.td(B);
        point I2 = point.td(A, B);

        Console.WriteLine("\nTrung diem:");

        Console.WriteLine(
            "Thanh vien: " + I1
        );

        Console.WriteLine(
            "Tinh: " + I2 );
    }
}