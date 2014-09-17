using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonSlayer2CombatSimulator
{
    //enumerations
    enum AttackType
    {
        Scythe,
        Cross,
        HolyWater

    }
    class Player
    {

        //properties
        public int PlayerHealth { get; set; }
        public bool IsAlive { set { this.IsAlive(PlayerHealth > 0); } }



        //constructors
        public Player(string PlayerHealth)
        {
            this.PlayerHealth = 710;
        }


        //methods
        public int DoAttack()
        {
            int userNum;
            Console.WriteLine("Enter 1 to perform a scytheSLash which has a 70% chance to do 100 damage." +
            "\nEnter 2 for crossAttack which has a 100% chance of doing 60 damage, and healing you for 20 HP." +
            "\nEnter 3 to use Holy Water which has a 30% chance to heal for 200 and a 70% chance to heal for 100");
            userNum = Convert.ToInt32(Console.ReadLine());
        }

        private AttackType ChooseAttack()
        {

        }

        public void TakeDamage(int damage)
        {

        }


    }
}
