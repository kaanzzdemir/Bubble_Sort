List<string> arabalar = new List<string>() { "Chev","Porsche","Renault"};
List<int> menu = new List<int>() { 0, 1, 2, 3 };
int i = 1;
Console.WriteLine("Araba sorgulama sistemine hoşgeldiniz...");
Console.WriteLine("1-Araba Ekleme");
Console.WriteLine("2-Araba Sorgula");
int ilk_secim = Convert.ToInt16(Console.ReadLine());
if (ilk_secim == 1)
{
    Console.WriteLine("Araba ekleme bölümüne hoşgeldiniz. Eklenecek arabanın adını giriniz.");
    string araba_adi = Console.ReadLine();
    arabalar.Add(araba_adi);
}
else if (ilk_secim == 2)
{
    Console.WriteLine("Araba sorgulama bölümüne hoşgeldiniz.");
    Console.WriteLine("Arabam var mı yok mu diye sorgulamak istiyorsanız 1");
    Console.WriteLine("Bütün arabaları sorgulamak istiyorsanız 2'yi tuşlayınız");
    int secim = Convert.ToInt32(Console.ReadLine());
    if (secim == 1)
    {
        Console.WriteLine("Arabanızın adını girin");
        string araba_ad = Console.ReadLine();
        foreach (var item in arabalar)
        {
            if (item.Contains(araba_ad) == true)
            {
                Console.WriteLine("Araba sistemde bulundu.");
                break;
            }
            else
            {
                Console.WriteLine("Araba sistemde bulunamadı."); 
                break;
            }

        }
    }
    else
    {
        foreach (var item in arabalar)
        {
            Console.WriteLine(i + ". " + item);
            i++;
        }
    }
}








