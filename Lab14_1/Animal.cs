using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_1
{
    public abstract class Animal
    {        
        public abstract string Name { get; set; }
                
        public Animal(string name) => Name = name;
                
        public abstract void Say();
                
        public void ShowInfo()
        {            
            Console.Write($"{Name} говорит ");            
            Say();
            Console.WriteLine();
        }
    }
}
