using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Line_Game1
{
    class Game
    {
        public void Run()
        {
            //Health Excr.
            int healthRegen = 50;
            int health = 100;
            health = 17;
            Console.Write("Current Health: " + (health + healthRegen));

            //Name Excr.
            string name = "Fool";
            Console.WriteLine("Enter Your name");
            name = Console.ReadLine();
            Console.WriteLine("Welcome, " + name);

            //Text_Adventure Excr.
            string charname = "Fool";
            string char_class;
            bool gameover = false;
            float charhealth;
            int chardamage;
            Console.WriteLine("Welcome adventurer");
            Console.WriteLine("You have been chosen to carry out a daring advanture.");
            Console.WriteLine("This adventure being...travelling amongst one of the most dangerous dungeons known to man");
            Console.WriteLine("The Dungeon of 4Chan, where all the good memes go to die.");
            Console.WriteLine("So, dear adventurer, what is your name?");
            charname = Console.ReadLine();
            Console.WriteLine(charname + "Brilliant.");
            Console.WriteLine("Now, what is your class?");
            Console.WriteLine("[B] Barbarian");
            Console.WriteLine("[W] Wizard");
            Console.WriteLine("[H] Healer");
            char_class = Console.ReadLine();
            if (char_class == "B" || char_class == "b")
            {
                Console.WriteLine("Barbarian. wonderful choice.");
                charhealth = 1000;
                chardamage = 45;
                Console.WriteLine("your HEALTH is " + charhealth);
                Console.WriteLine("Your DAMAGE is " + chardamage);
            }
            else if (char_class == "W" || char_class == "w")
            {
                Console.WriteLine("Wizard. wonderful choice.");
                charhealth = 1000;
                chardamage = 35;
                Console.WriteLine("your HEALTH is " + charhealth);
                Console.WriteLine("Your DAMAGE is " + chardamage);
            }
            else if (char_class == "H" || char_class == "h")
            {
                Console.WriteLine("Wizard. wonderful choice.");
                charhealth = 1000;
                chardamage = 25;
                Console.WriteLine("your HEALTH is " + charhealth);
                Console.WriteLine("Your DAMAGE is " + chardamage);
            }
        }
    }
}
