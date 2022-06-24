
Matematik mtx = new Matematik();
Console.WriteLine("Girilmiş değerli : " + mtx.topla(1, 1));
Console.WriteLine("Girilmiş değerli : " + mtx.topla(1, 1, 5));
Console.WriteLine("Default değerli : " + mtx.topla(1,5));
Console.WriteLine("Karışık girilmiş değerli : " + mtx.topla(sayi2: 1, sayi1: 10)); //Eşittir değil iki nokta

Console.WriteLine(mtx.ToplaParams(1,2,3,4,5,6,7,8,9,10));

class Matematik
{
    public int topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public int topla(int sayi1, int sayi2, int sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }
    //Yapılan işleme overloading denir. Aynı isimli birden fazla metot olabilir, fakat parametreleri farklı olmalıdır.

    public int ToplaParams(params int[] sayilar) // params bize çok büyük bir kolaylık sağlıyor. Buraya istediğimiz kadar parametre yazabiliyoruz.
    {
        int sonuc = 0;
        foreach (var item in sayilar)
        {
            sonuc += item;
        }
        return sonuc;
        //return sayilar.Sum(); farklı bir toplama şekli (foreach'e gerek yok) 
    }
}