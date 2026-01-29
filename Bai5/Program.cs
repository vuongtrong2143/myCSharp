Console.OutputEncoding = System.Text.Encoding.UTF8;

// 1. Nhập liệu (Rút gọn)
Console.Write("Nhập số phần tử n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
// Nguyễn Vương Trọng 2415053122143
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Phần tử [{i}]: ");
    arr[i] = int.Parse(Console.ReadLine() ?? "0");
}

int ketQua = TimMax(arr);
Console.WriteLine($"\nGiá trị lớn nhất là: {ketQua}");
int TimMax(int[] data)
{
    int max = data[0]; // gia su phan tu max la phan tu dau tien
    for (int i = 1; i < data.Length; i++)
    {
        if (data[i] > max)
        {
            max = data[i];
        }
    }
    return max;
}