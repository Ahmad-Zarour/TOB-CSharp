using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursuppgift
{
   public class ComparisonGame
    {
        public string name { get; set; }

        private int health;
        private int strength;
        private int Luck;


        public ComparisonGame()
        {
        }
        public ComparisonGame(string name)
        {
            this.name = name;
        }


        public void setRandomValues()
        {
            Random random = new Random();
            this.health = random.Next(0, 100);
            this.strength = random.Next(0, 100);
            this.Luck = random.Next(0, 100);
            Console.Write($"Hälsa   ");
            drowBar(health);
            Console.Write($"Styrka  ");
            drowBar(strength);
            Console.Write($"Tur     ");
            drowBar(Luck);

        }
        public void drowBar(int value)
        {
            int level = value / 2;
            Console.Write("[");
            for (int i =0;i<=level;i++)
                Console.Write("#");
            Console.Write("] "+ value + "%\n");
        }


    }
}
