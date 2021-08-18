using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Line_Game1
{
    class Game
    {
        public void Run()
        {
            string Excercise_Choice;
            Console.WriteLine("Which Program would you like to run?");
            Console.WriteLine("[1] Text Adventure");
            Console.WriteLine("[2] Name Excercise");
            Console.WriteLine("[3] Health Excercise");
            Console.WriteLine("[4] Job Excercise");
            Console.WriteLine(">");
            Excercise_Choice = Console.ReadLine();
            if (Excercise_Choice == "1" || Excercise_Choice.ToLower() == "text adventure")
            {
                Console.Clear();
                TextAdventure();
            }
            else if (Excercise_Choice == "1" || Excercise_Choice.ToLower() == "name excercise")
            {
                Console.Clear();
                NameExcr();
            }
        }

        public void TextAdventure()
        {
            //Text_Adventure Excr.
            string charname = "Fool";
            string UserInput;
            string char_class;
            bool gameover = false;
            float charhealth;
            int chardamage;
            Console.WriteLine("Welcome adventurer");
            Console.ReadKey();
            Console.WriteLine("You have been chosen to carry out a daring advanture.");
            Console.ReadKey();
            Console.WriteLine("This adventure being...travelling amongst one of the most dangerous dungeons known to man");
            Console.ReadKey();
            Console.WriteLine("The Horrible Dungeon of Deadly Creatures");
            Console.ReadKey();
            Console.WriteLine("Whoever named this dungeon is definitelty terrible with names.");
            Console.ReadKey();
            Console.WriteLine("Speaking of names, dear adventurer, what is your name?");
            Console.ReadKey();
            Console.WriteLine(">");
            charname = Console.ReadLine();
            Console.WriteLine(charname + ". Brilliant.");
            Console.ReadKey();
            Console.WriteLine("Now, what is your class?");
            Console.ReadKey();
            Console.WriteLine("[B] Barbarian");
            Console.ReadKey();
            Console.WriteLine("[W] Wizard");
            Console.ReadKey();
            Console.WriteLine("[H] Healer");
            Console.ReadKey();
            char_class = Console.ReadLine();
            if (char_class.ToLower() == "b")
            {
                Console.WriteLine("Barbarian. wonderful choice.");
                charhealth = 1000;
                chardamage = 45;
                Console.WriteLine("your HEALTH is " + charhealth);
                Console.WriteLine("Your DAMAGE is " + chardamage);
            }
            else if (char_class.ToLower() == "w")
            {
                Console.WriteLine("Wizard. wonderful choice.");
                charhealth = 1000;
                chardamage = 35;
                Console.WriteLine("your HEALTH is " + charhealth);
                Console.WriteLine("Your DAMAGE is " + chardamage);
            }
            else if (char_class.ToLower() == "h")
            {
                Console.WriteLine("Wizard. wonderful choice.");
                charhealth = 1000;
                chardamage = 25;
                Console.WriteLine("your HEALTH is " + charhealth);
                Console.WriteLine("Your DAMAGE is " + chardamage);
            }
            Console.WriteLine("Now, it is time for us to go forward");
            Console.ReadKey();
            Console.WriteLine("Whilist travelling through the dark, eerie dungeon, you hear the sound of a horrid croak echo through the halls of the dungeon.");
            Console.ReadKey();
            Console.WriteLine("It's a bullfrog, specifically a large one. That's like half the size of you.");
            Console.ReadKey();
            Console.WriteLine("What do you do?");
            Console.WriteLine("[A] Attack");
            Console.WriteLine("[B] Interact");
            Console.WriteLine(">");
            UserInput = Console.ReadLine();
            if (UserInput.ToLower() == "attack" || UserInput.ToLower() == "a")
            {
                Console.WriteLine("You attack the bullfrog");
                Console.ReadKey();
                Console.WriteLine("The Bullfrog looks offended that you could harm some innocent life.");
                Console.ReadKey();
                Console.WriteLine("The frog dies, you gain slime but loose your sense of morality");
                Console.ReadKey();
                Console.WriteLine("Nonetheless, you venture onward into dungeon, surely the monsters further down are much scarier than just a bullfrog half your height");
                Console.ReadKey();
                Console.WriteLine("As you travel even deeper into the dungeon you come across two chests");
                Console.ReadKey();
                Console.WriteLine("In front of the chest is a sign, ");

            }
            else if (UserInput.ToLower() == "Interact" || UserInput.ToLower() == "b")
            {
                Console.WriteLine("You attempt to interact with the frog.");
                Console.ReadKey();
                Console.WriteLine("The bullfrog laughs, calls you a fool and kills you.");
                Console.ReadKey();
                Console.WriteLine("GameOver");
                Console.ReadKey();

            }
        }

        public void HealthExcr()
        {
            //Health Excr.
            int healthRegen = 50;
            int health = 100;
            health = 17;
            Console.Write("Current Health: " + (health + healthRegen));
            Console.Clear();
        }

        public void NameExcr()
        {
            //Name Excr.
            string name = "Fool";
            Console.WriteLine("Enter Your name");
            name = Console.ReadLine();
            Console.WriteLine("Welcome, " + name);
            Console.Clear();
        }

        public void JobExcr()
        {
            //Job Conditional Excr.
            string job;
            string charjob;
            int power;
            Console.WriteLine("What job would you like?");
            Console.WriteLine("[1] Lizard");
            Console.WriteLine("[2] Knight");
            Console.Write(">");
            job = Console.ReadLine();
            if (job == "1" || job.ToLower() == "lizard")
            {
                charjob = "Lizard";
                health = 3000;
                power = 30;

                Console.WriteLine("Your job is " + charjob);
                Console.WriteLine("Your health is " + health);
                Console.WriteLine("Your power is " + power);
            }
            else if (job == "2" || job.ToLower() == "Kinght")
            {
                charjob = "Kight";
                health = 4000;
                power = 40;

                Console.WriteLine("Your job is " + charjob);
                Console.WriteLine("Your health is " + health);
                Console.WriteLine("Your power is " + power);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
