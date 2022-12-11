using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public virtual string Name { get; set; }

        public virtual void GetCry()
        {
            Console.WriteLine("Абстрактный клич");
        }
    }

    class Cat : Animal
    {
        public override void GetCry()
        {
            base.GetCry();
            Console.Write(": Мяу");
        }
    }
    class Dog : Animal
    {
        public override void GetCry()
        {
            Console.WriteLine("GAv");
        }
    }
    class Elephant: Animal
    {
        public override string Name { get => base.Name; set => base.Name = value; }
    }

}
