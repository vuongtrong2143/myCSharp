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

int ketQua = DemSoPhanTuChan(arr);
Console.WriteLine($"\nSố phần tử chẵn là: {ketQua}");
int DemSoPhanTuChan(int[] data)
{
    int so = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i]%2 == 0)
        {
            so++;
        }
    }
    return so;
}