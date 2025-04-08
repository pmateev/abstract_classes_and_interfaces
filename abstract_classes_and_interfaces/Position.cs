using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    public abstract class Position : Person, IHierarchy
    {
        public abstract string PositionLevel { get; set; }

        public void Level()
        {
            Console.WriteLine($"I'm currently {PositionLevel}.");
        }

        public override void Show()
        {
            Level();
        }
    }
}
