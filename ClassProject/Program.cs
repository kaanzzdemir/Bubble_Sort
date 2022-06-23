using ClassProject;

Students std = new Students();
int menuDeger = 0;
int i = 1;
std.StudentId = "192804006";
std.StudentName = "Kaan";
std.StudentMail = "kaanzzdemir@gmail.com";

List<Students> student = new List<Students>() {std};

void BaslangicMenu()
{
    Console.WriteLine("1-Sisteme Öğrenci Ekle");
    Console.WriteLine("2-Sistemdeki Tüm Öğrencileri Gör");
    Console.WriteLine("3-Okul Numarasından Öğrenci Bul");
    Console.Write("Seçim:");
    menuDeger = Convert.ToInt16(Console.ReadLine());
}
menuDeger = 0;
BaslangicMenu();


if (menuDeger == 1)
{
    std = new Students();
    Console.Write("Öğrenci Numarası :");
    std.StudentId = Console.ReadLine();
    Console.Write("Öğrenci Adı :");
    std.StudentName = Console.ReadLine();
    Console.Write("Öğrenci Maili :");
    std.StudentMail = Console.ReadLine();
    student.Add(std);
    Console.WriteLine(std.StudentName);
    Console.WriteLine(std.StudentId);
    Console.WriteLine(std.StudentMail);
    
}
else if (menuDeger == 2)
{
    foreach (var item in student)
    {
        Console.WriteLine(i + ". Öğrenci :" + item.StudentName);
        i++;
    }
    
}
else if (menuDeger == 3)
{
    Console.Write("Sorgulanacak Öğrencinin Numarasını Giriniz : ");
    string ogrNo = Console.ReadLine();
    foreach (var item in student)
    {
        if (ogrNo == item.StudentId)
        {
            Console.WriteLine("Sonuç bulundu!");
            Thread.Sleep(1000);
            Console.WriteLine(item.StudentId + " numaralı öğrencinin adı : " + item.StudentName); 
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("Sonuç bulunamadı...");
        }
    }
    
}
BaslangicMenu();