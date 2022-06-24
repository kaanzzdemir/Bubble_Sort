using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class PersonManager
    {
        List<Person> people;
        public PersonManager()
        {
            people = new List<Person>()
            {
                new Person(1,"Kaan","Özdemir","kaan@gmail.com"),
                new Person(2,"Ali","Panpanllı","ali@gmail.com"),
                new Person(3,"Kemal","Erlik"),
            };
        }
        public void addPerson(Person person)
        {
            people.Add(person);

            if (people.Count > 3)
            {
                Console.WriteLine("Kayıt başarılı...");
                foreach (var item in people)
                {
                    Console.WriteLine(item.PersonName + " " + item.PersonMail);
                }

            }
            else
            {
                Console.WriteLine("Kayıt başarısız...");
            }

        }
    }
}
