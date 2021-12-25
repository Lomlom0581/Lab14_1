using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_1
{
    class Cat : Animal
    {

        public Cat(string name) : base(name) { }
                
        public override string Name { get; set; }
                
        public override void Say()
        {
            Console.Write("Мяу!");
        }
    }
}
