using System;

public class Bai5
{
    static double x,y;
    static bool nhap= false;
    static void canbac()
    {
         if(!ktnhap()) return;
         if(x<0)
           Console.WriteLine("Can Bac Hai cua " + x + ": Khong xac dinh");
            else
              Console.WriteLine("Can Bac Hai cua "+x+": "+Math.Sqrt(x));
        if (y<0)
         Console.WriteLine("Can Bac Hai cua " + y + ": Khong xac dinh");
         else
        Console.WriteLine("Can Bac Hai cua "+y+": "+Math.Sqrt(y));
    }
    static void nhapxy()
    {
        Console.Write("Nhap x: ");
         while(!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Nhap x khong hop le!");
            Console.Write("Nhap x: ");
        }

        Console.Write("Nhap y: ");
        while(!double.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Nhap y khong hop le!");
            Console.Write("Nhap y: ");
        }

        nhap =true;
    }
    static bool ktnhap()
    {
        if (!nhap)
        {
            Console.WriteLine("Chua nhap x,y!!");
            return false;
        }
        return true;
    }
    static void tinhmu()
    {
         if(!ktnhap()) return;
        Console.WriteLine(x+"^"+y+" = "+ Math.Pow(x,y));
    }
    public static void run()
    {
        int chon;
        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                chon = 0;
            }
            switch(chon)
            {
                 case 1:
                   nhapxy();
                   break;
                 case 2:
                    tinhmu();
                    break;
                  case 3:
                     canbac();
                     break;
                   case 4:
                     Console.WriteLine("Thoat!");
                     break;
                   default:
                      Console.WriteLine("Lua chon Khong Hop Le!!!");
                      break;                   
            }
        }while( chon !=4);
    }
}