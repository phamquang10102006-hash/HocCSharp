using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThucHanhLINQ
{
 public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }
    }

    public class He
    {
        public string MaHe { get; set; } = "";
        public string TenHe { get; set; } = "";
    }

    public static class DuLieu
    {
        public static List<MonHoc> DS_Mon()
        {
            return new List<MonHoc>
            {
                new MonHoc { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "JLCB",  TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
                new MonHoc { MaMon = "LINQ",  TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
                new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "CC++",  TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
                new MonHoc { MaMon = "JQUE",  TenMon = "JQuery", He = "CD", SoTiet = 22 },
                new MonHoc { MaMon = "XML",   TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "CRYS",  TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "BWEB",  TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "XYZ",   TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
            };
        }

        public static List<He> DS_He()
        {
            return new List<He>
            {
                new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
                new He { MaHe = "CD",  TenHe = "Chuyên đề" },
                new He { MaHe = "QT",  TenHe = "Chứng chỉ quốc tế" }
            };
        }
    }
	class program
	{
		static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            InTieuDe("BÀI 2.1: TRUY VẤN MẢNG SỐ NGUYÊN");
            Bai21();

            InTieuDe("BÀI 2.2: TRUY VẤN MẢNG CHUỖI");
            Bai22();

            InTieuDe("BÀI 3.1: THỐNG KÊ MẢNG SỐ");
            Bai31();

            InTieuDe("BÀI 3.2: THỐNG KÊ MẢNG CHUỖI");
            Bai32();

            InTieuDe("BÀI 5.1: TRUY VẤN CƠ BẢN LIST<MONHOC>");
            Bai51();

            Console.WriteLine("\n=== HOÀN THÀNH BÀI THỰC HÀNH LINQ ===");
            Console.ReadLine();
        }
		static void InTieuDe(string title)
        {
            Console.WriteLine("\n================================================");
            Console.WriteLine($" {title}");
            Console.WriteLine("==================================================");
        }
		static void Bai21()
		{
			int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
			Console.WriteLine("=== Bài 2.1a ===");
			var KetquaA = mangSo.Where(x => x%4==0 && x%3==0);
			Console.WriteLine("Các phần tử chia hết cho 4 và 3:");

	        foreach (var x in KetquaA)
	        {
	            Console.Write(x + " ");
	        }
	
	        Console.WriteLine();
	        Console.WriteLine();
			
			Console.WriteLine("=== Bài 2.1b ===");

	        var ketQuaB = mangSo.Where(x => x <= 3);
	
	        Console.WriteLine("Các phần tử nhỏ hơn hoặc bằng 3:");
	
	        foreach (var x in ketQuaB)
	        {
	            Console.Write(x + " ");
	        }
	
	        Console.WriteLine();
	        Console.WriteLine();
	
	        
	        Console.WriteLine("=== Bài 2.1c ===");
	
	        var ketQuaC = mangSo.Select(x =>
	            x % 2 == 0 ? x / 2 : x
	        );
	
	        Console.WriteLine("Dãy mới:");
	
	        foreach (var x in ketQuaC)
	        {
	            Console.Write(x + " ");
	        }
	
	        Console.WriteLine();
		}
		static void Bai22()
		{
		    string[] mangChuoi =
		    {
		        "đầu", "lòng", "hai", "ả", "tố", "nga",
		        "Thúy", "Kiều", "là", "chị", "em", "là",
		        "Thúy", "Vân"
		    };
		
		    Console.WriteLine("=== Bài 2.2a ===");
		
		    var ketQuaA = mangChuoi
		        .Where(x => x.Length == 4)
		        .OrderBy(x => x[0]);
		
		    Console.WriteLine("Các phần tử có 4 ký tự, sắp xếp theo ký tự đầu:");
		
		    foreach (var x in ketQuaA)
		    {
		        Console.Write(x + " ");
		    }
		
		    Console.WriteLine();
		    Console.WriteLine();
		
		    Console.WriteLine("=== Bài 2.2b ===");
		
		    var ketQuaB = mangChuoi.Select(x =>
		        $"{x.ToLower()} - {x.ToUpper()}"
		    );
		
		    Console.WriteLine("Dạng chữ thường - CHỮ HOA:");
		
		    foreach (var x in ketQuaB)
		    {
		        Console.WriteLine(x);
		    }
		
		    Console.WriteLine();
		    Console.WriteLine("=== Bài 2.2c ===");
		
		    var ketQuaC = mangChuoi
		        .Where(x => x.Contains("u", StringComparison.OrdinalIgnoreCase));
		
		    Console.WriteLine("Các phần tử có chứa ký tự 'u':");
		
		    foreach (var x in ketQuaC)
		    {
		        Console.Write(x + " ");
		    }
		
		    Console.WriteLine();
		    Console.WriteLine();
		
		    Console.WriteLine("=== Bài 2.2d ===");
		
		    var ketQuaD = mangChuoi.Where(x => char.IsUpper(x[0]));
		
		    Console.WriteLine("Các từ bắt đầu bằng chữ in hoa:");
		
		    foreach (var x in ketQuaD)
		    {
		        Console.Write(x + " ");
		    }
		
		    Console.WriteLine();
		}
		static void Bai31()
		{
		    int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
		
		    Console.WriteLine("=== Bài 3.1a ===");
		
		    int tongSoPhanTu = mangSo.Count();
		    int soPhanTuChan = mangSo.Count(x => x % 2 == 0);
		    int soPhanTuLe = mangSo.Count(x => x % 2 != 0);
		
		    Console.WriteLine($"Tổng số phần tử: {tongSoPhanTu}");
		    Console.WriteLine($"Số phần tử chẵn: {soPhanTuChan}");
		    Console.WriteLine($"Số phần tử lẻ: {soPhanTuLe}");
		
		    Console.WriteLine();
		    Console.WriteLine("=== Bài 3.1b ===");
		
		    int tong = mangSo.Sum();
		    int lonNhat = mangSo.Max();
		    int nhoNhat = mangSo.Min();
		
		    Console.WriteLine($"Tổng các giá trị: {tong}");
		    Console.WriteLine($"Giá trị lớn nhất: {lonNhat}");
		    Console.WriteLine($"Giá trị nhỏ nhất: {nhoNhat}");
		
		    Console.WriteLine();
		    Console.WriteLine("=== Bài 3.1c ===");
		
		    int soGiaTriKhacNhau = mangSo.Distinct().Count();
		
		    Console.WriteLine($"Số giá trị khác nhau: {soGiaTriKhacNhau}");
		
		    Console.WriteLine();
		    Console.WriteLine("=== Bài 3.1d ===");
		
		    var nhom = mangSo.GroupBy(x => x % 5);
		
		    foreach (var group in nhom)
		    {
		        Console.Write($"Số dư {group.Key}: ");
		
		        foreach (var x in group)
		        {
		            Console.Write(x + " ");
		        }
		
		        Console.WriteLine();
		    }
		}
		static void Bai32()
		{
		    string[] monAn =
		    {
		        "Bún bò Huế",
		        "Hủ tiếu heo",
		        "Bánh canh",
		        "Bánh mì",
		        "Nước Cà phê",
		        "Mì quảng",
		        "Cơm tấm",
		        "Nước Chanh dây",
		        "Mì xào",
		        "Bún riêu",
		        "Bánh cuốn",
		        "Mì gói",
		        "Bún chả",
		        "Hủ tiếu Nam vang"
		    };
		
		    Console.WriteLine("=== Bài 3.2a ===");
		
		    int doDaiNhoNhat = monAn.Min(x => x.Length);
		    int doDaiLonNhat = monAn.Max(x => x.Length);
		
		    var monNganNhat = monAn.Where(x => x.Length == doDaiNhoNhat);
		    var monDaiNhat = monAn.Where(x => x.Length == doDaiLonNhat);
		
		    Console.WriteLine("Món có chiều dài ngắn nhất:");
		    foreach (var mon in monNganNhat)
		    {
		        Console.WriteLine(mon);
		    }
		
		    Console.WriteLine("Món có chiều dài dài nhất:");
		    foreach (var mon in monDaiNhat)
		    {
		        Console.WriteLine(mon);
		    }
		
		    Console.WriteLine();
		    Console.WriteLine("=== Bài 3.2b ===");
		
		    var nhomMon = monAn.GroupBy(x => x.Split(' ')[0]);
		
		    foreach (var group in nhomMon)
		    {
		        Console.WriteLine($"Nhóm {group.Key}:");
		
		        foreach (var mon in group)
		        {
		            Console.WriteLine($"  {mon}");
		        }
		    }
		
		    Console.WriteLine();
		    Console.WriteLine("=== Bài 3.2c ===");
		
		    int soMonBanh = monAn.Count(x =>
		        x.StartsWith("Bánh ", StringComparison.OrdinalIgnoreCase));
		
		    Console.WriteLine($"Số món có từ đầu tiên là 'Bánh': {soMonBanh}");
		}
		static void Bai51()
		{
		    List<MonHoc> dsMon = DuLieu.DS_Mon();
		
		    Console.WriteLine("=== Bài 5.1a ===");
		
		    var ketQuaA = dsMon
		        .Where(mon => mon.TenMon.StartsWith("Lập trình"));
		
		    foreach (var mon in ketQuaA)
		    {
		        Console.WriteLine(mon.TenMon);
		    }
		
		    Console.WriteLine();
		    Console.WriteLine("=== Bài 5.1b ===");
		
		    var ketQuaB = dsMon
		        .Where(mon => mon.He == "CD")
		        .OrderByDescending(mon => mon.SoTiet)
		        .ThenBy(mon => mon.MaMon);
		
		    foreach (var mon in ketQuaB)
		    {
		        Console.WriteLine(
		            $"{mon.MaMon} | {mon.TenMon} | {mon.He} | {mon.SoTiet}"
		        );
		    }
		
		    Console.WriteLine();
		    Console.WriteLine("=== Bài 5.1c ===");
		
		    var ketQuaC = dsMon
		        .Where(mon => mon.TenMon.Contains(
		            "web",
		            StringComparison.OrdinalIgnoreCase))
		        .Select(mon => new
		        {
		            mon.TenMon,
		            mon.He
		        });
		
		    foreach (var mon in ketQuaC)
		    {
		        Console.WriteLine($"{mon.TenMon} | {mon.He}");
		    }
		
		    Console.WriteLine();
		    Console.WriteLine("=== Bài 5.1d ===");
		
		    var ketQuaD = dsMon
		        .Where(mon => mon.He == "KTV")
		        .OrderBy(mon => mon.MaMon);
		
		    foreach (var mon in ketQuaD)
		    {
		        Console.WriteLine(
		            $"{mon.MaMon} | {mon.TenMon} | {mon.SoTiet}"
		        );
		    }
		}
		
	}
}