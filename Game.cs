using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Line_Game1
{
    class Game
    {
        public void Run()
        {
            //For-Loop Excr.
            int numberOfTries = 4;
            string riddle_answer;
            bool riddleSolved;
            Console.WriteLine("An old man with a monkey on his back approaches you." + "\n \" I can offer you immortality as long as you solve my riddle within  " + numberOfTries + " tries. He says");
            Console.ReadKey();
            for (int i = 0; i < numberOfTries; i++)
            {
                int numOfAttmpsLeft = numberOfTries;
                Console.Clear();
                Console.WriteLine("What has to be broken before you can use it.");
                Console.WriteLine("Attempts remaining " + (numOfAttmpsLeft - i));
                Console.Write(">");
                riddle_answer = Console.ReadLine();
                if (riddle_answer.ToLower() == "egg")
                {
                    Console.WriteLine("Congratulations. You gained immortality");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    Console.ReadKey();
                    Console.Clear();
                }
            }



            //Job Conditional Excr.
            string job;
            string charjob;
            bool ValidJob = false;
            int power;
            int health;
            Console.WriteLine("What job would you like?");
            Console.WriteLine("[1] Lizard");
            Console.WriteLine("[2] Knight");
            Console.Write(">");
            job = Console.ReadLine();
            while (!ValidJob)
            {
                if (job == "1" || job.ToLower() == "lizard")
                {
                    ValidJob = true;
                    charjob = "Lizard";
                    health = 3000;
                    power = 30;

                    Console.WriteLine("Your job is " + charjob);
                    Console.ReadKey();
                    Console.WriteLine("Your health is " + health);
                    Console.ReadKey();
                    Console.WriteLine("Your power is " + power);
                    Console.ReadKey();
                }
                else if (job == "2" || job.ToLower() == "Kinght")
                {
                    ValidJob = true;
                    charjob = "Kight";
                    health = 4000;
                    power = 40;

                    Console.WriteLine("Your job is " + charjob);
                    Console.ReadKey();
                    Console.WriteLine("Your health is " + health);
                    Console.ReadKey();
                    Console.WriteLine("Your power is " + power);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("What job would you like?");
                    Console.WriteLine("[1] Lizard");
                    Console.WriteLine("[2] Knight");
                    Console.Write(">");
                    job = Console.ReadLine();
                }
            }

            //Health Excr.
            int healthRegen = 50;
            health = 17;
            Console.Write("Current Health: " + (health + healthRegen));
            Console.Clear();

            //Name Excr.
            string name = "Fool";
            Console.WriteLine("Enter Your name");
            name = Console.ReadLine();
            Console.WriteLine("Welcome, " + name);
            Console.Clear();


            //Text_Adventure Excr.
            string charname = "Fool";
            string UserInput = "";
            bool validInput = false;
            string char_class;
            bool gameover = false;
            float charhealth;
            int chardamage;
            int numOfChests = 4;
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
            while (!validInput)
            {
                if (char_class.ToLower() == "b")
                {
                    validInput = true;
                    Console.WriteLine("Barbarian. wonderful choice.");
                    charhealth = 1000;
                    chardamage = 45;
                    Console.WriteLine("your HEALTH is " + charhealth);
                    Console.WriteLine("Your DAMAGE is " + chardamage);
                }
                else if (char_class.ToLower() == "w")
                {
                    validInput = true;
                    Console.WriteLine("Wizard. wonderful choice.");
                    charhealth = 1000;
                    chardamage = 35;
                    Console.WriteLine("your HEALTH is " + charhealth);
                    Console.WriteLine("Your DAMAGE is " + chardamage);
                }
                else if (char_class.ToLower() == "h")
                {
                    validInput = true;
                    Console.WriteLine("Healer. wonderful choice.");
                    charhealth = 1000;
                    chardamage = 25;
                    Console.WriteLine("your HEALTH is " + charhealth);
                    Console.WriteLine("Your DAMAGE is " + chardamage);
                }
                else
                {
                    Console.WriteLine("That is not a valid class");
                    char_class = Console.ReadLine();
                }
            }
            validInput = false;
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
            while (validInput == false)
            {
                if (UserInput.ToLower() == "attack" || UserInput.ToLower() == "a")
                {
                    validInput = true;
                    Console.WriteLine("You attack the bullfrog");
                    Console.ReadKey();
                    Console.WriteLine("The Bullfrog looks offended that you could harm some innocent life.");
                    Console.ReadKey();
                    Console.WriteLine("The frog dies, you gain slime but lose your sense of morality");
                    Console.ReadKey();
                    Console.WriteLine("Nonetheless, you venture onward into dungeon, surely the monsters further down are much scarier than just a bullfrog half your height");
                    Console.ReadKey();
                    Console.WriteLine("As you travel even deeper into the dungeon you come across four chests");
                    Console.ReadKey();
                    Console.WriteLine("In front of the chest is a sign, which reads \"One of these chests holds the key to the doors in front, and another a Mimic that will devour you whole\""
                        + "\"And these last two chests hold nothing at all");
                    Console.ReadKey();
                    for (int i = 0; i < numOfChests; i++)
                    {
                        int chestsLeft = numOfChests;
                        Console.WriteLine("Which Chest will you choose?" + "\n [1] Chest 1 \n[2] Chest 2 \n [3] Chest 3 \n [4] Chest 4");
                        string ChestChosen = Console.ReadLine();
                        if (ChestChosen == "1" || ChestChosen.ToLower() == "chest 1")
                        {

                        }
                        else if (ChestChosen == "3" || ChestChosen.ToLower() == "chest 3")
                        {

                        }
                        else
                        { 

                        }
                    }

                }
                else if (UserInput.ToLower() == "Interact" || UserInput.ToLower() == "b")
                {
                    validInput = true;
                    Console.WriteLine("You attempt to interact with the frog.");
                    Console.ReadKey();
                    Console.WriteLine("The bullfrog laughs, calls you a fool and kills you.");
                    Console.ReadKey();
                    Console.WriteLine("GameOver");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                    UserInput = Console.ReadLine();
                }
            }
        }
    }
}
