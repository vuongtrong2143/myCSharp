using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập họ tên: ");
        string? hoTen = Console.ReadLine();
        // 1. Kiểm tra Null hoặc Rỗng
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            Console.WriteLine("Lỗi: Chuỗi rỗng hoặc chỉ chứa khoảng trắng!");
            return;
        }
        // Trim() xoá đầu/cuối. Split() tách từ và xoá khoảng trắng thừa ở giữa
        string[] cacTu = hoTen.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string ketQua = "";
        foreach (string tu in cacTu)
        {
            string tuChuanHoa = char.ToUpper(tu[0]) + tu.Substring(1);
            ketQua += tuChuanHoa + " ";
        }
        Console.WriteLine("Kết quả: " + ketQua.Trim());
        Console.ReadKey();
    }
}