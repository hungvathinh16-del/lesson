using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lesson
{
    internal class Menu
    {
        
        static void Main(string[] args)
        {
            Animal Lu = new Dog("Lu");
            Animal Mun = new Cat("Mun");

            Lu.Keu();
            Mun.Keu();
        }

        public class Animal
        {
            public string Ten { get; set; }

            public Animal() { }
            public Animal(string name) { this.Ten = name; }

            public virtual void Keu()
            {
                Console.WriteLine("Động vật đang kêu...");
            }
        }

        public class Dog : Animal
        {
            public Dog(string name) : base(name) { }
            public override void Keu()
            {
                Console.WriteLine("Gâu gâu!");
            }
        }

        public class Cat : Animal
        {
            public Cat(string name) : base(name) { }
            public override void Keu()
            {
                Console.WriteLine("Meo Meo!");
            }
        }

    }
    
    
}
