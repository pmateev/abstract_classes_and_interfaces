using interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Support : IHeal, IDefend
    {
        public void Heal()
        {
            Console.WriteLine("Support is healing the others with healing magic!");
        }
        public void Defend()
        {
            Console.WriteLine("Support is defending with magic shield!");
        }
    }
}
