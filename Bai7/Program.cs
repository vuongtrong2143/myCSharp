// Cau hinh tieng Viet cho input va output
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
// Nguyễn Vương Trọng 2415053122143
// Nhap ten
Console.Write("Nhập họ tên: ");
string? hoten = Console.ReadLine();

string[]? mangcacTu = TachChuoi(hoten);

if (mangcacTu != null)
{
    Console.WriteLine("Cac tu trong ten:");
    foreach (string u in mangcacTu)
    { 
        Console.WriteLine(u);
    }
}
else
{
    Console.WriteLine("Chuoi vao la Null!");
}
// Hàm tách chuỗi
string[]? TachChuoi(string? hoten)
{
    if (hoten == null) return null;
    return hoten.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
}
