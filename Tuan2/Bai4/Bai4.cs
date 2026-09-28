using System;

public class Bai04
{
    public class phanso
    {
        private int tu;
        private int mau;
        public phanso()
        {
            tu=0;
            mau=1;
        }
        public phanso(phanso other)
        {
            tu=other.tu;
            mau=other.mau;
        }
        public phanso(int tu)
        {
            this.tu=tu;
            this.mau=1;
        }
        public phanso(int tu, int mau)
        {
            if (mau == 0)
            throw new ArgumentException("Mau so khong duoc bang 0!");

            this.tu=tu;
            this.mau=mau;
        }
        public int Tu
        {
            get{return tu;}
            set{tu=value; }
        }
        public int Mau
        {
            get{return mau; }
            set
            {
                if(value==0)
                throw new ArgumentException("Mau so phai khac 0!");

                mau=value;
            }
        }

        public int GCD(int tu, int mau)
        {
            while(tu != mau)
            {
                if(tu> mau) tu = tu-mau;
                if(mau> tu) mau= mau-tu; 
            }
            return tu;
        }


        public void rutgon()
        {
            if (mau < 0)
            {
                tu = -tu;
                mau = -mau;
            }

            int gcd = GCD(Math.Abs(tu), Math.Abs(mau));

            if (gcd != 0)
            {
                tu /= gcd;
                mau /= gcd;
            }
        }

        public override string ToString()
        {
            if(mau==1) return tu.ToString();
            return tu + "/" +mau;
        }
        //1 ngoi
        public static phanso operator +(phanso a)
        {
            return new phanso(a.tu,a.mau);
        }
        public static phanso operator -(phanso a)
        {
            return new phanso(-a.tu,a.mau);
        }
        //2 ngoi
        public static phanso operator +(phanso a, phanso b)
        {
            return new phanso(a.tu*b.mau + a.mau*b.tu, a.mau*b.mau);
        }
        public static phanso operator -(phanso a, phanso b)
        {
            return new phanso(a.tu*b.mau - a.mau*b.tu, a.mau*b.mau);
        }
        public static phanso operator *(phanso a, phanso b)
        {
            return new phanso(a.tu*b.tu, a.mau*b.mau);
        }
        public static phanso operator /(phanso a, phanso b)
        {
            if(b.tu==0) throw new DivideByZeroException();
            return new phanso(a.tu*b.mau, a.mau*b.tu);
        }

        public static bool operator >(phanso a, phanso b)
        {
            return a.tu* b.mau > a.mau* b.tu;
        }

        public static bool operator <(phanso a, phanso b)
        {
            return a.tu* b.mau < a.mau* b.tu;
        }

         public static bool operator <=(phanso a, phanso b)
        {
            return a.tu* b.mau <= a.mau* b.tu;
        }
         public static bool operator >=(phanso a, phanso b)
        {
            return a.tu* b.mau >= a.mau* b.tu;
        }

         public static bool operator ==(phanso a, phanso b)
        {
            return a.tu* b.mau == a.mau* b.tu;
        }

        public static bool operator !=(phanso a, phanso b)
        {
            return a.tu* b.mau != a.mau* b.tu;
        }

        public override bool Equals(object? obj)
        {
            if (obj is phanso other)
            return this == other;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(tu, mau);
        }
    }
    public static void run()
    {
        phanso a = new phanso(1, 2);
        phanso b = new phanso(2, 3);

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));

        Console.WriteLine("+a = " + (+a));
        Console.WriteLine("-a = " + (-a));

        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a >= b: " + (a >= b));
        Console.WriteLine("a <= b: " + (a <= b));
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));
    
    }
}