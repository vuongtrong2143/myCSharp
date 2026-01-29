// Nguyễn Vương Trọng 2415053122143
Console.OutputEncoding = System.Text.Encoding.UTF8;

string?[] Chuoicanxet = { null, " ", "abc", "" };
int sophantu = Demsophantukhacnullkhacrong(Chuoicanxet);
Console.WriteLine("Số phần tử khác null và khác rỗng là: " + sophantu);
// Hàm tách chuỗi
int Demsophantukhacnullkhacrong(string?[] mang)
{
    int a = 0;
    foreach(string? s in mang)
    {
        if (s != null && s.Length != 0)
        {
            a++;
        }
    }
    return a;
}
