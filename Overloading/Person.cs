using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Person
    {
        public Person()
        {

        }
        public Person(int personId, string personName, string personSurname, string personMail)
        {
            PersonId = personId;
            PersonName = personName;
            PersonSurname = personSurname;
            PersonMail = personMail;
        }
        public Person(int personId, string personName, string personSurname)
        {
            PersonId = personId;
            PersonName = personName;
            PersonSurname = personSurname;
        }

        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string PersonMail { get; set; }
    }
}
