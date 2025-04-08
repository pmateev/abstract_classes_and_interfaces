using interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Ranger : IAttack, IHeal
    {
        public void Attack()
        {
            Console.WriteLine("Ranger is attacking with his bow!");
        }
        public void Heal()
        {
            Console.WriteLine("Ranger is healing himself with first aid equipment!");
        }
    }
}
