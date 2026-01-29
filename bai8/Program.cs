// Cau hinh tieng Viet cho input va output
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
// Nguyễn Vương Trọng 2415053122143
// Nhap ten
Console.Write("Nhập 1 câu: ");
string? nhapcau = Console.ReadLine();
string? tudainhat = Timtudainhat(nhapcau);

if (tudainhat != null)
{
    // Console.WriteLine($"Từ dài nhất trong tên: {tudainhat}");
    Console.WriteLine("Từ dài nhất trong tên: " + tudainhat);
}
else
{
    Console.WriteLine("Chuoi vao la Null!");
}

// Hàm tách chuỗi
string? Timtudainhat(string? nhapcau)
{
    if (nhapcau == null) return null;
    string[] danhsachcacTu = nhapcau.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    if (danhsachcacTu.Length == 0) return null;
    string maxTu = danhsachcacTu[0];
    for (int i = 1; i < danhsachcacTu.Length; i++)
    {
        if (danhsachcacTu[i].Length > maxTu.Length)
        {
            maxTu = danhsachcacTu[i];
        }
    }
    return maxTu;
}
