using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the castle of the evil King Alexander!");
            Console.WriteLine();
            Console.WriteLine("Your quest is to defeat the king before he conquers the land with his undead army.");
            /*Console.WriteLine("Pick a number: 1, 2 or 3");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("correct");
            }
            */
            Console.WriteLine("Press enter if you accept this quest, otherwise leave and die like the coward you are, you freak!");
            Console.ReadLine();

            Console.WriteLine("You enter the castle, and you find yourself staring at a undead soldier who is running towards you!");
            Console.WriteLine("Press 1 to stab him in the head");
            Console.WriteLine("Press 2 to dodge and slash him in the back");
            Console.WriteLine("Press 3 to run away and go home");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("You tried stabbing him in the head, but he blocked it with his bone shield!");
                Console.WriteLine("After he blocks your attack, he stands toe to toe with you. What do you do?");
                Console.WriteLine("Press 1 to kick him in the pelvic region");
                Console.WriteLine("Press 2 to punch him in the face");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("You kicked him where it hurts... Did I forget to tell you that he's undead? Because he is.");
                    Console.WriteLine("You stand there, and you look embarrassed. As you should be. What do you do now?");
                    Console.WriteLine("Press 1 to shake his hand, and give up.");
                    Console.WriteLine("Press 2 to poke him in the eyes like the cartoons.");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        Console.WriteLine("You shake his hand, but the undead soldier is confused yet thankful that you gave up.");

                    }
                    else if (option == "2")
                    {

                        Console.WriteLine("You poke him in the eyes, but he's undead. Like I said twice before. You're an idiot.");
                    }




                    Console.WriteLine("Game Over. Try again next time!");
                }


                if (choice == "2")
                {
                    Console.WriteLine("You punched him in the face, which made him fall on the ground and crumble.");
                    Console.WriteLine("Good job! You killed the last soldier in the castle!");
                }




            }


            else if (input == "2")
            {
                Console.WriteLine("You strike him in the back of his head, and he crumbles in to dust! Nice job!");

            }
            else if (input == "3")
            {
                Console.WriteLine("You run away like a coward. Hope you're proud of yourself.");
                Console.WriteLine("Game Over. Try again next time.");

            }
            else
            {
                Console.WriteLine("You twit. The option you have selected is invalid. Try again next time.");
            }

            //this is the end
        }
    }
}
