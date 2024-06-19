using System.Xml.Linq;

namespace The_Adventures_of_Scoooter
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dragon dragon1 = new Dragon();

            dragon1.Name = "PABE";
            dragon1.monsterAttack = "breathing fire";


            Hero hero1 = new Hero();

            hero1.Name = "Scoooter";
            hero1.Weapon1 = "bow and Arrow";
            hero1.Weapon2 = "Magical Sword";
            hero1.ArrowType = "fire Arrow";




            Princess princess1 = new Princess();

            princess1.Name = "Penelope";
           


            Allies allies1 = new Allies();

            allies1.Name = "Myrtle and Girdle";
            allies1.flyAbility = "shot bird seed";

            Knight knight1 = new Knight();

            knight1.Name = "Sir Boopie";
            knight1.SpecialAbility = "bit";





            Console.WriteLine($"Once upon a time in a kingdom far away, there was a legendary Hero named {hero1.Name}.");
            Console.WriteLine($"There was also a captured Princess named {princess1.Name}.");
            Console.WriteLine($"As legend goes...the kingdom, and {princess1.Name} were threatened by a fercious dragon named {dragon1.Name}.");
            Console.WriteLine($"In order to save {princess1.Name}, you must help {hero1.Name} defeat {dragon1.Name} and" +
                $" restore peace to the kingdom.");
            Console.WriteLine($"You will not fight this battle alone. You have allies named {allies1.Name} and a knight named {knight1.Name} to" +
                $" assist \nyou on this journey...");
            Console.WriteLine();
            string userInput;

            do
            {
                Console.WriteLine("Please type 'start' to begin:");
                userInput = Console.ReadLine().Trim().ToLower();

                if (userInput != "start")
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

            } while (userInput != "start");
            Console.WriteLine();
            Console.WriteLine($"{dragon1.Name} has Princess {princess1.Name} captured in a wooden crate. " +
                $" How do you wish to proceed? ");
            Console.WriteLine($"1. {hero1.Weapon1}");
            Console.WriteLine($"2. {hero1.Weapon2}");
            Console.WriteLine();
            string weaponChoice;
            do
            {
                Console.Write("Enter the number of your choice (1 or 2): ");
                weaponChoice = Console.ReadLine().Trim();
                Console.WriteLine();

                switch (weaponChoice)
                {
                    case "1":
                        Console.WriteLine($"You've chosen the {hero1.Weapon1} and shot a {hero1.ArrowType} freeing Princess {princess1.Name}" +
                            $" from the crate!");
                        break;
                    case "2":
                        Console.WriteLine("You've chosen the sword. This will not work here. Game Over!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }

            } while (weaponChoice != "1" && weaponChoice != "2");

            Console.WriteLine($"{dragon1.Name} now wants to battle!");
            Console.WriteLine("How do you wish to proceed?");
            Console.WriteLine("Choose your action:");
            Console.WriteLine($"1. Call in your allies {allies1.Name} as well as your knight {knight1.Name}?");
            Console.WriteLine($"2. Use {hero1.Weapon2}?");
            Console.WriteLine($"3. Use {hero1.Weapon1}?");
            Console.WriteLine();


            string actionChoice;
            do
            {
                Console.Write("Enter the number of your choice (1, 2, or 3): ");
                actionChoice = Console.ReadLine().Trim();

                switch (actionChoice)
                {
                    case "1":
                        Console.WriteLine($"You called in your allies {allies1.Name}\n" +
                            $"They {allies1.flyAbility} weakening {dragon1.Name}, and your knight {knight1.Name} also {knight1.SpecialAbility} {dragon1.Name}!");

                        Console.WriteLine($"Do you wish to use the {hero1.Weapon2} ?");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");
                        Console.WriteLine();

                        string finishChoice;
                        do
                        {
                            Console.Write("Enter your choice (1 or 2): ");
                            finishChoice = Console.ReadLine().Trim();

                            switch (finishChoice)
                            {
                                case "1":
                                    Console.WriteLine($"You've chosen to use {hero1.Weapon2} as the finishing move against {dragon1.Name}. Congratulations, you have saved Princess {princess1.Name} and the kingdom!");
                          
                                    return; 
                                case "2":
                                    Console.WriteLine($"You need to have more to defeat {dragon1.Name} than the {hero1.Weapon2}. Game Over!");
                              
                                    return; 
                                default:
                                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                                    break;
                            }

                        } while (finishChoice != "1" && finishChoice != "2");

                        break; 

                    case "2":
                        Console.WriteLine($"You've chosen to use {hero1.Weapon2}. This is not effective against {dragon1.Name}. Game Over!");
                        
                        return; 
                    case "3":
                        Console.WriteLine($"You've chosen to use {hero1.Weapon1}. {allies1.Name} and {knight1.Name} must be called. Game Over!");
                        
                        return; 
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }

            } while (actionChoice != "1" && actionChoice != "2" && actionChoice != "3");





        }


    }
}
