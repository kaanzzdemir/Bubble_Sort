int[] sayilar = new int[] { 1, 2, 3, 4 };
int[] sayilar2 = new int[] { 10, 20, 30, 40 };

sayilar = sayilar2; //sayilar dizisini sayilar2 dizisi ile bağladık. Ama değer olarak değil, birbirine sıkı bağlandı referans oldu.

//sayilar[0] = 10000; //ikisinin de 0. elemanı değişti.
//Console.WriteLine(sayilar2[0]); //10 yazmasını bekliyoruz. Fakat referans olarak birbirine bağlandığından sayilar[0]. elemanı bağlanan dizinin elemanlarını da etkiliyor.

Person person = new Person();
//person.Id;
//person.Name;
//person.Surname;
Employee employee = new Employee();
//employee.Id;
//employee.Name;
//employee.Surname;
//employee.EmployeeNumber;
Customer customer = new Customer();
//customer.Id;
//customer.Name;
//customer.Surname;
//customer.CreditCard;

Person person2 = new Person();
//person.Name = "Kaan";
person2 = person; //değer değil, referansları eşleşti.
//Console.WriteLine(person2.Name);
//person.Name = "Dalga";
//Console.WriteLine(person2.Name); //person'un adını değiştirmemize rağmen person2'nin de adı değişti.

customer.Name = "Salih";
Person person3 = customer; //Sıkıntı çıkartmadı. Çünkü her customer aslında zaten bir person'dır.
//person3.Id;
//person3.Name;
//person3.Surname; //Yalnız bir sıkıntı var. Customer'in özelliği olan CreditCard'ı burada kullanamıyoruz. Onun için boxing yapacağız aşağıda.
//Console.WriteLine(person3.Name); //Person3'ün özellikleri artık customer'dan alınabiliyor. Farkındaysanız üstte customer'ın adını Salih yaptık ve bunu daha demin adreslerini eşlediğimiz person3<->customer ikilisine de aktardır. Artık person3'ün adı "Salih"

int customerCreditCard = ((Customer)person3).CreditCard = 12345; //Daha demin person3'de creditcard prop'una ulaşamadık ama boxing yaptığımızda ulaşabiliyoruz...

//Console.WriteLine(customerCreditCard);

PersonManager personManager = new PersonManager();
employee.Name = "Mehmet Yeni";
customer.Name = "Ali Yeni";
person.Name = "Veli Yeni";
personManager.Add(employee);
personManager.Add(customer);
personManager.Add(person);
//Genel olarak açıklayacak olursak. Person, customer ve employee sınıfının base class'ı. Person'da bulunan özellikleri bunlar kullanabiliyorlar. Onu kalıtım alıyorlar. Ve genel olarak ekleme silme güncelleme işlemleri yapılmak istediğinde Manager class'a person'u parametre olarak gönderirsek, diğer classları (employee ve customer) kullanabiliyor. Yani tek bir ekleme kod bloğunda 3 farklı nesneyi veritabanına ekleyebiliyoruz. Aynı kodu farklı nesneler için kullanabiliyoruz.

class Person //Person burada base class'dır.
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Surname { get; set; }
}

class Employee : Person //Employee class'ını Person ile kalıttık. Yani artık her employee'nin "Id,Name,Surname" i var.
{
    public int EmployeeNumber { get; set; }
}
class Customer : Person
{
    public int CreditCard { get; set; } //Customer class'ını Person ile kalıttık. Yani artık her customer'ın "Id,Name,Surname" i var. Ekstradan creditcard diye bir özelliği var.
}
class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.Name);
    }
}

