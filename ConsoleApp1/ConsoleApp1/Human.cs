using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Human
    {
        private string name;
        private int age;
        private string sex;
        //public Human(string name, int age, string sex)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //    this.Sex = sex;
        //}
        public string Name { get { return name; } set { name = value; } }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }
        public string Sex { get { return sex; } set { sex = value; } }

        public void GetInfo()
        {
            Console.WriteLine(name + age + 
                sex);
        }
    }
}
