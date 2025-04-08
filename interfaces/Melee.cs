using interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Melee : IAttack, IDefend
    {
        public void Attack()
        {
            Console.WriteLine("Melee is attacking with his sword!");
        }
        public void Defend()
        {
            Console.WriteLine("Melee is defending with his shield!");
        }
    }
}
