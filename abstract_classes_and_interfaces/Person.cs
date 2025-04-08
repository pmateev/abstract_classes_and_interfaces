using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    public abstract class Person
    {
        public string Name { get; set; }
        public abstract int Age { get; set; }

        public void Info()
        {
            Console.WriteLine($"My name is {Name}. I'm {Age} years old.");
        }

        public abstract void Show();
    }
}
