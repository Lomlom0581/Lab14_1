using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка");
            Dog dog = new Dog("Барбос");


            cat.ShowInfo();
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
}
