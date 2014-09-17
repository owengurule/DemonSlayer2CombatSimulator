using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonSlayer2CombatSimulator
{
    class Enemy
    {
        public string Name { get; set; }
        public int DemonHealth { get; set; }
        public bool IsAlive { set { this.IsAlive(DemonHealth > 0); } }

        public Enemy(string PlayerHealth)
        {
            this.DemonHealth = 666;
        }

        public int DoAttack()
        {

        }

        public void TakeDamage(int damage)
        {

        }
    }
}
