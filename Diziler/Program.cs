int[] sayilar = new int[5] { 5, 32, 24, 11, 68 };

foreach (var item in sayilar)
{
    Console.Write(item + " ");
}

int kucukDeger;

for (int i = 0; i < sayilar.Length; i++)
{
    for(int j = 0; j < sayilar.Length; j++)
    {
        if (sayilar[i] < sayilar[j])
        {
            kucukDeger = sayilar[i];
            sayilar[i] = sayilar[j];
            sayilar[j] = kucukDeger;
        }
    }
}
Console.WriteLine("\n");
foreach (var item in sayilar)
{
    Console.Write(item + " ");
}
