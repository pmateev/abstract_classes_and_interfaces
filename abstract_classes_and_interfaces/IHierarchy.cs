using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    public interface IHierarchy
    {
        string PositionLevel { get; set; }
        void Level();
    }
}
