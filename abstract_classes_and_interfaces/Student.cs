using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    public class Student : Position
    {
        public override int Age { get; set; }
        public override string PositionLevel { get; set; } = "Student";

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"{Name} is studying.");
        }
    }
}
