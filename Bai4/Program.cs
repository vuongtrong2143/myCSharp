Console.OutputEncoding = System.Text.Encoding.UTF8;
// Nguyễn Vương Trọng 2415053122143
// --- NHẬP DỮ LIỆU ---
Console.Write("Nhập số phần tử n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Phần tử [{i}]: ");
    int.TryParse(Console.ReadLine(), out arr[i]);
}

long ketQua = TinhTongKieuMoi(arr);
Console.WriteLine($"\nTổng mảng là: {ketQua}");

// --- HÀM TÍNH TỔNG (LOCAL FUNCTION) ---
long TinhTongKieuMoi(int[]? data)
{
    if (data is null)
    {
        Console.WriteLine("--> Lỗi: Mảng bị null, không tính được!");
        return 0;
    }
    long sum = 0;
    foreach (var item in data)
    {
        sum += item;
    }
    return sum;
}