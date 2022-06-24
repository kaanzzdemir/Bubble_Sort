using GeneralProject1;
int secim = 0;

Console.WriteLine("----------Teknoya'ya hoşgeldiniz.-----------");
//Ürünleri listelemeye ihtiyaç,ürün eklemeye, ürün silmeye, ürün güncellemeye ihtiyaç
ProductManager productManager = new ProductManager();

Menu();

if (secim == 1)
{
    foreach (var item in productManager.GetAll())
    {
        Console.WriteLine(item.ProductId + " ID'li Ürün\n-------------------------\n" + "Adı: " + item.ProductName + "\n" + "Fiyatı: " + item.ProductPrice + "\n" + "Stok adedi: " + item.ProductStock);
        Thread.Sleep(500);
    }
}
if (secim == 2)
{
    int productId, productStock, productPrice;
    string productName;
    Console.Write("ID: ");
    productId = Convert.ToInt16(Console.ReadLine());
    Console.Write("Name: ");
    productName = Console.ReadLine();
    Console.Write("Price: ");
    productPrice = Convert.ToInt16(Console.ReadLine());
    Console.Write("Stock: ");
    productStock = Convert.ToInt16(Console.ReadLine());
    Product product = new Product() { ProductId = productId, ProductName = productName, ProductPrice = productPrice, ProductStock = productStock };
    productManager.AddProduct(product);
    Console.WriteLine("\n\n"); 
    Thread.Sleep(1000);
    foreach (var item in productManager.GetAll())
    {
        Console.WriteLine(item.ProductId + " ID'li Ürün\n-------------------------\n" + "Adı: " + item.ProductName + "\n" + "Fiyatı: " + item.ProductPrice + "\n" + "Stok adedi: " + item.ProductStock);
        Thread.Sleep(500);
    }
}
if (secim == 3)
{
    int productId, productStock, productPrice;
    string productName;
    Console.Write("ID: ");
    productId = Convert.ToInt16(Console.ReadLine());
    Console.Write("Name: ");
    productName = Console.ReadLine();
    Console.Write("Price: ");
    productPrice = Convert.ToInt16(Console.ReadLine());
    Console.Write("Stock: ");
    productStock = Convert.ToInt16(Console.ReadLine());
    Product product = new Product() { ProductId = productId, ProductName = productName, ProductPrice = productPrice, ProductStock = productStock };
    productManager.AddProduct(product);
    Console.WriteLine("\n\n");
    Thread.Sleep(1000);
    foreach (var item in productManager.GetAll())
    {
        Console.WriteLine(item.ProductId + " ID'li Ürün\n-------------------------\n" + "Adı: " + item.ProductName + "\n" + "Fiyatı: " + item.ProductPrice + "\n" + "Stok adedi: " + item.ProductStock);
        Thread.Sleep(500);
    }
}

void Menu()
{
    Console.WriteLine("Hangi işlemleri yapmak istersiniz?");
    Console.WriteLine("1-Ürünleri Listele");
    Console.WriteLine("2-Ürün Ekle");
    Console.WriteLine("3-Ürün Sil");
    Console.WriteLine("4-Ürün Güncelle");
    Console.Write("Seçiminiz: ");
    secim = Convert.ToInt16(Console.ReadLine());
}