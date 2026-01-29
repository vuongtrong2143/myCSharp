using System;

namespace DemSoTu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập chuỗi bất kỳ: ");
            string? input = Console.ReadLine();
            int ketQua = DemSoTu(input);
            Console.WriteLine($"Số từ đếm được: {ketQua}");
            Console.ReadKey();
        }
        static int DemSoTu(string? str)
        {
            if (str == null) // Nếu chuỗi null → in 0
            {
                return 0;
            }
            string[] danhSachTu = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return danhSachTu.Length;
        }
    }
}