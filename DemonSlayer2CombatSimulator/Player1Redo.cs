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
        Scythe = 1,
        Cross,
        HolyWater

    }
    class Player
    {


        //properties
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        


        public int HP { get; set; }
        public bool IsAlive { get { return this.HP > 0; } }

                private Random rng = new Random();

        //constructors
        public Player(int HP)
        {
            this.HP = 710;
        }


        //methods
        public void Battle()
        {
            //declare damage
            int damage;
            //switch statement to perform attack
            switch(ChooseAttack())
            {
                case AttackType.Scythe:
                    if (rng.Next(0, 101) > 30 )
                   damage = rng.Next(175, 201);
                        enemy.HP -= damage;
                    Console.WriteLine("{0} deals {1} damage to {2}", this.Name, damage, enemy.Name);
            }
        }




        private AttackType ChooseAttack()
        {

            Console.WriteLine(@"
Choose Attack:
1.Scythe, 70% chance to do 175 - 200 damage
2.Cross, 100% chance of doing 60 damage and healing you for 20
3.Holy Water, has a 30% chance to heal for 200 and a 70% chance to heal for 100");
            //get input
            int input = int.Parse(Console.ReadLine());
            //return the selected attack type.
                return (AttackType)input;

        }


    }
}
