using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorTest
{
    internal class Manager
    {
        public Manager(int id) //Overloading (aynı blokların farkılı parametreler ile gerçekleşmesi) "Constructor" için de kullanılır.
        {
            
        }
        public Manager()
        {
            Console.WriteLine("Constructor'daki yazı...");
        }
        public void Yazdir()
        {
            Console.WriteLine("Constructor'daki yazı değil...");
        }

    }
}
