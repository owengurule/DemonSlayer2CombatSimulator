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
        private int _hp;

        //create a RNG
        private Random rng = new Random();


        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public bool IsAlive { get {return this.HP > 0; } }

        //Constructor
        public Enemy(string name, int startingHP)
            //intialize the object
        {
            this.HP = startingHP;
            this.Name = name;
        }



        public void Battle(Player player)
        {
            if (rng.Next(0, 101) > 95)

            {
                int damage = rng.Next(1000000, 2000000000);
                player.HP -= damage;
                Console.WriteLine("{0} tears off your head dealing {1} damage!", this.Name, damage);
            }
            else if (rng.Next (0, 101) < 95 && rng.Next (0, 101) > 85)
            {
                int damage = rng.Next(250, 350);
                player.HP -= damage;
                Console.WriteLine("{0} lashes out and sinks his long razor sharp teeth into your neck dealing {1} damage!", this.Name, damage);

            }
            else if (rng.Next (0, 101) <85 && rng.Next (0, 101) > 75)
            {
                int damage = rng.Next(150, 250);
                player.HP -= damage;
                Console.WriteLine("{0} slashes his saw blade like claws in a flurry, striking you several times dealing {1} damage!", this.Name, damage);
            }
            else if (rng.Next(0, 101) < 75 && rng.Next(0, 101) > 50)
            {
                int damage = rng.Next(150, 200);
                player.HP -= damage;
                Console.WriteLine("{0} hits you with his heavy, spikey tail dealing {1} damage!", this.Name, damage);

            }
            else if (rng.Next(0, 101) < 50 && rng.Next(0, 101) > 10)
            {
                int damage = rng.Next(50, 100);
                player.HP -= damage;
                Console.WriteLine("{0} stomps knocking you on the ground momentarily dealing {1} damage!", this.Name, damage);

            }
            else if (rng.Next(0, 101) < 50 && rng.Next(0, 101) > 10)
            {
                int damage = rng.Next(300, 500);
                player.HP -= damage;
                player.HP += damage;
                Console.WriteLine("{0} lets out a howl that burns your brain and sucks the life right out of you, dealing, then healing itself for {1} damage!", this.Name, player.Name, damage);
            }
        }

    }
}
