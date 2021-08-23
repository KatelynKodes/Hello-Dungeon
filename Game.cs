using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Line_Game1
{
    class Game
    {
        string charname = "Fool";
        string UserInput = "";
        bool validInput;
        string char_class;
        bool gameover = false;
        float charhealth;
        int chardamage;
        int numOfChests = 4;

        public void Run()
        {
            validInput = false;
            gameover = false;
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
            Console.WriteLine("Now, what is your class? \n [B] Barbarian \n [W] Wizard \n [H] Healer");
            Console.WriteLine(">");
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
            BullfrogEncounter();
            validInput = false;
            if (!gameover)
            { 
                ChestEncounter();
                validInput = false;
                if (!gameover)
                {
                    GooseEncounter();
                    validInput = false;
                    if (!gameover)
                    {
                        BingusEncounter();
                        validInput = false;
                        Console.WriteLine("You exit the dungeon, filled with glee that you managed to escape alive.");
                        Console.WriteLine("You go back to the town, ready to go home and prepare yourself for the adventure that " +
                            "awaits you tomorrow.");
                        PlayAgain();

                    }
                    else
                    {
                        PlayAgain();
                    }
                }
                else
                {
                    PlayAgain();
                }
            }
            else
            {
                PlayAgain();
            }
        }

        //TEXT ADVENTURE METHODS

        //Encounter1
        public void BullfrogEncounter()
        {
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
                    gameover = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                    UserInput = Console.ReadLine();
                }
            }
        }

        //Encounter2
        public void ChestEncounter()
        {
            bool checkedChest2 = false;
            bool checkedChest4 = false;
            bool keynotfound = true;

            Console.WriteLine("Nonetheless, you venture onward into dungeon, surely the monsters further down are much scarier than just a bullfrog half your height");
            Console.ReadKey();
            Console.WriteLine("As you travel even deeper into the dungeon you come across four chests");
            Console.ReadKey();
            Console.WriteLine("In front of the chest is a sign, which reads \"One of these chests holds the key to the doors in front, and another a Mimic that will devour you whole\""
                + "\"And these last two chests hold nothing at all");
            for (int i = 0; i < numOfChests; i++)
            {
                int chestsLeft = numOfChests;
                Console.WriteLine("Which Chest will you choose?" + "\n [1] Chest 1 \n [2] Chest 2 \n [3] Chest 3 \n [4] Chest 4");
                Console.WriteLine("Number of attempts left: " + (chestsLeft = chestsLeft - i));
                string ChestChosen = Console.ReadLine();
                if (ChestChosen == "1" || ChestChosen.ToLower() == "chest 1")
                {
                    Console.WriteLine("Upon examining the first chest, four animalistic legs sprout out from the bottom. The chest opens to reveal a large toothy mouth that could devour you whole.");
                    Console.WriteLine("The chest violently attacks you, killing you almost instantly.");
                    gameover = true;
                    break;
                }
                else if (ChestChosen == "3" || ChestChosen.ToLower() == "chest 3")
                {
                    Console.WriteLine("Upon examining the third chest, you unlock it to find a golden key matching the doors in front of you.");
                    Console.WriteLine("You grab the key and proceed forward.");
                    keynotfound = false;
                    break;
                }
                else
                {
                    if ((ChestChosen == "2" || ChestChosen.ToLower() == "chest 2") || (ChestChosen == "4" || ChestChosen.ToLower() == "chest 4"))
                    {
                        if (ChestChosen == "2" || ChestChosen.ToLower() == "chest 2")
                        {
                            if (checkedChest2)
                            {
                                Console.WriteLine("You already checked chest 2");
                            }
                            else
                            {
                                Console.WriteLine("Upon examining the second chest, you're dissapointed to find nothing at all.");
                                Console.WriteLine("You don't get the key.");
                            }
                        }
                        else
                        {
                            if (checkedChest4)
                            {
                                Console.WriteLine("You already checked chest 4");
                            }
                            else
                            {
                                Console.WriteLine("Upon examining the fourth chest, you're dissapointed to find nothing at all.");
                                Console.WriteLine("You don't get the key.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. You don't get the key.");
                    }
                }
            }
            if ()
            {
                
            }
            
        }

        //Encounter3
        public void GooseEncounter()
        {
            Console.WriteLine("Once you pass through the doors after the chests, you're met with yet another treacherous beast.");
            Console.ReadKey();
            Console.WriteLine("A....Goose? Holding a knife.");
            Console.ReadKey();
            Console.WriteLine("Such a monstrosity.");
            Console.ReadKey();
            Console.WriteLine("Somehow the chests were better.");
            Console.ReadKey();
            Console.WriteLine("Anyways, what do you do? \n [A] Attack Goose \n [B] Threaten Goose \n [C] Try to pass Goose");
            Console.WriteLine(">");
            UserInput = Console.ReadLine();
            while (!validInput)
            {
                if (UserInput.ToLower() == "a" || UserInput.ToLower() == "attack")
                {
                    validInput = true;
                    Console.WriteLine("You attack the goose!");
                    Console.ReadKey();
                    Console.WriteLine("The goose, despite dying a painful death, seens to admire your violent tendencies.");
                    Console.ReadKey();
                    Console.WriteLine("Truly an agent of chaos.");
                    Console.ReadKey();
                    Console.WriteLine("The goose finally dies, no longer inflicting it's crimes of destruction onto anybody again.");
                    Console.ReadKey();
                    Console.WriteLine("It also can't commit tax fraud anymore so that's good");
                    Console.ReadKey();
                }
                else if (UserInput.ToLower() == "b" || UserInput.ToLower() == "threaten" || UserInput.ToLower() == "threaten goose")
                {
                    validInput = true;
                    Console.WriteLine("You threaten the goose.");
                    Console.ReadKey();
                    Console.WriteLine("The goose is impressed by your threat");
                    Console.ReadKey();
                    Console.WriteLine("Yes, you seem like a violent yet reliable accomplaice.");
                    Console.ReadKey();
                    Console.WriteLine("The goose gives you a gun.");
                    Console.ReadKey();
                    Console.WriteLine("got gun.");
                    Console.ReadKey();
                }
                else if (UserInput.ToLower() == "c" || UserInput.ToLower() == "pass" || UserInput.ToLower() == "pass goose")
                {
                    validInput = true;
                    Console.WriteLine("You try to pass the goose peacefully.");
                    Console.ReadKey();
                    Console.WriteLine("You are peaceful, therefore you are weak");
                    Console.ReadKey();
                    Console.WriteLine("Mercy is for the weak.");
                    Console.ReadKey();
                    Console.WriteLine("The goose starts running full speed towards you, knife in beak");
                    Console.ReadKey();
                    Console.WriteLine("It kills you as you desprately try to reach for the door.");
                    Console.ReadKey();
                    Console.WriteLine("Game Over");
                    gameover = true;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    UserInput = Console.ReadLine();
                }
            }
        }

        //Encounter4
        public void BingusEncounter()
        {
            int BingusPets = 0;
            int BingusAttacks = 0;
            int Playerdamage = 0;
            bool bingusTurn = false;

            Console.WriteLine("Entering the last room of the dungeon, you are met with a gigantic cat-like monstrosity");
            Console.ReadKey();
            Console.WriteLine("It's name being...");
            Console.ReadKey();
            Console.WriteLine("Bingus");
            Console.ReadKey();
            Console.WriteLine("(Seriously who comes up with these names?)");
            Console.ReadKey();
            Console.WriteLine("Whatever, names aside.");
            Console.ReadKey();
            while (!(BingusPets == 3 || BingusAttacks == 3 || Playerdamage == 3))
            {
                if (bingusTurn)
                {
                    Console.WriteLine("Bingus takes one of his paws and swipes at you. Attacking you");
                    Playerdamage++;
                    bingusTurn = false;
                }
                else
                {
                    Console.WriteLine("What do you do?");
                    Console.WriteLine(" [A] Attack Bingus \n [B] Pet Bingus");
                    UserInput = Console.ReadLine();
                    if (UserInput.ToLower() == "a" || UserInput.ToLower() == "attack")
                    {
                        BingusAttacks++;
                        Console.WriteLine("You attack bingus, managing to do some damage.");
                        Console.ReadKey();
                        Console.WriteLine("Bingus lets out a loud hiss at you.");
                        Console.ReadKey();
                        bingusTurn = true;
                    }
                    else if (UserInput.ToLower() == "b" || UserInput.ToLower() == "pet")
                    {
                        BingusPets++;
                        Console.WriteLine("You reach up and manage to give Bingus a scratch on the head.");
                        Console.ReadKey();
                        Console.WriteLine("A low rumble comes from the monsterous cat. It seems to like it.");
                        Console.ReadKey();
                        bingusTurn = true;

                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                        bingusTurn = true;
                    }
                }
            }

            if (BingusAttacks == 3)
            {
                Console.WriteLine("You finally manage to kill the almighty Bingus.");
                Console.WriteLine("Your are truly a beast to be reckoned with.");
            }
            else if (BingusPets == 3)
            {
                Console.WriteLine("You manage to tame the almighty Bingus.");
                Console.WriteLine("Your are truly a beast to be reckoned with.");
            }
            else if (Playerdamage == 3)
            {
                Console.WriteLine("You die a terrible death at the paws of bingus.");
                Console.WriteLine("Much like those who have fallen before you.");
                gameover = true;
            }
        }

        //PlayAgain Method
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("[Y] Yes \n [N] No");
            Console.WriteLine(">");
            UserInput = Console.ReadLine();
            while (!validInput)
            {
                if (UserInput.ToLower() == "y" || UserInput.ToLower() == "yes")
                {
                    validInput = true;
                    Console.Clear();
                    Run();
                }
                else if(UserInput.ToLower() == "n" || UserInput.ToLower() == "no")
                {
                    validInput = true;
                }
            }
        }


        //LODIS DEMONSTRATIONS
        
        //PrintAllEvenNums example
        /// <summary>
        /// Prints all even numbers from num 1 to num 2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        void PrintAllEven(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //For-Loop Demonstration.
        public void MonkeyManExcr()
        {
            //For-Loop Excr.
            int numberOfTries = 4;
            string riddle_answer;
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
        }


        //Option Choices
        public void ChooseJob(string desc, string option1, string option2)
        {
            int inputrecieved = 0;

            Console.WriteLine(desc);
            Console.WriteLine(option1 + "\n" + option2);
            string input = Console.ReadLine();

            while (!(inputrecieved == 1 || inputrecieved == 2))
            {
                if (input == "1" || input.ToLower() == option1.ToLower())
                {
                    inputrecieved = 1;
                    Console.WriteLine(option1);
                }
                else if (input == "2" || input.ToLower() == option2.ToLower())
                {
                    inputrecieved = 2;
                    Console.WriteLine(option2);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    input = Console.ReadLine();
                }
            }


        }

        //Health Excr.
        public void HealthVariableExcr()
        {
            int healthRegen = 50;
            int health = 100;
            health = 17;
            Console.Write("Current Health: " + (health + healthRegen));
            Console.Clear();
        }

        //Name Excr.
        public void NameExcr()
        {
            string name = "Fool";
            Console.WriteLine("Enter Your name");
            name = Console.ReadLine();
            Console.WriteLine("Welcome, " + name);
            Console.Clear();
        }
    }
}
