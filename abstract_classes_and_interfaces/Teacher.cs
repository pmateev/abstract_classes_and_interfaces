using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    public class Teacher : Position
    {
        public override int Age { get; set; }
        public override string PositionLevel { get; set; } = "Teacher";

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"{Name} is teaching.");
        }
    }
}
