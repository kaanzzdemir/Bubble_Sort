using Overloading;
string ad, soyad, mail;
int id;
Console.Write("Ad : ");
ad = Console.ReadLine();
Console.Write("Soyad : ");
soyad = Console.ReadLine();
Console.Write("Mail (isteğe bağlı) : ");
mail = Console.ReadLine();



Person person = new Person();

person.PersonName = ad;
person.PersonSurname = soyad;
person.PersonMail = mail;

PersonManager personManager = new PersonManager();
personManager.addPerson(person);