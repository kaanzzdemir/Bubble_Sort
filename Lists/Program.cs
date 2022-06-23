string[] sehirler = new string[] {"İstanbul", "Ankara", "İzmir" };
Console.WriteLine(sehirler.Length);

List<string> sehirler2 = new List<string>() { "Ankara", "İstanbul", "İzmir"}; //Listeyi oluşturma

sehirler2.Add("Sinop"); //Listeye eleman ekleme

Console.WriteLine(sehirler2.Count);//Listedeki elemanların sayısını alma (diziler için : sehirler.Lenght)

foreach (var item in sehirler2)//Listeyi dolaşmak için foreach döngüsü oluşturma
{
    Console.WriteLine(item);//Listedeki elemanları yazdırma
}

sehirler2.Remove("İstanbul");//Listeden eleman silme