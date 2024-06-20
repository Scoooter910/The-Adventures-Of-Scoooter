using System.Xml.Linq;

namespace The_Adventures_of_Scoooter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dragon dragon1 = new Dragon { Name = "PABE", MonsterAttack = "breathing fire" };
            Hero hero1 = new Hero { Name = "Scoooter", Weapon1 = "bow and Arrow", Weapon2 = "Magical Sword", ArrowType1 = "fire Arrow", ArrowType2 = "ice arrow" };
            Princess princess1 = new Princess { Name = "Penelope" };
            Allies allies1 = new Allies { Name = "Myrtle and Girdle", FlyAbility = "shot bird seed" };
            Knight knight1 = new Knight { Name = "Sir Boopie", SpecialAbility = "bite" };

            Console.WriteLine($"Once upon a time in a kingdom far away, there was a legendary Hero named {hero1.Name}.");
            Console.WriteLine($"There was also a captured Princess named {princess1.Name}.");
            Console.WriteLine($"As legend goes...the kingdom, and {princess1.Name} were threatened by a ferocious dragon named {dragon1.Name}.");
            Console.WriteLine($"In order to save {princess1.Name}, you must help {hero1.Name} defeat {dragon1.Name} and restore peace to the kingdom.");
            Console.WriteLine($"You will not fight this battle alone. You have allies named {allies1.Name} and a knight named {knight1.Name} to assist \nyou on this journey...");
            Console.WriteLine();

            Console.WriteLine("Please type 'start' to begin:");
            string userInput;
            do
            {
                userInput = Console.ReadLine()?.Trim().ToLower();
            } while (userInput != "start");

            bool success = false;

            // Stage 1: Use bow and arrow
            Console.WriteLine($"{dragon1.Name} has Princess {princess1.Name} captured in a wooden crate. How do you wish to proceed? ");
            Console.WriteLine();
            Console.WriteLine($"1. Use the {hero1.Weapon1} and shoot a {hero1.ArrowType1} to free Princess {princess1.Name}.");
            Console.WriteLine($"2. Use the {hero1.Weapon2}.");
            Console.WriteLine();

            string actionChoice;
            do
            {
                Console.Write("Enter the number of your choice (1 or 2): ");
                actionChoice = Console.ReadLine()?.Trim();

                switch (actionChoice)
                {
                    case "1":

                        Console.WriteLine($"You've chosen to use the {hero1.Weapon1} and shot a {hero1.ArrowType1} to free Princess {princess1.Name} from the crate!");
                        Console.WriteLine();
                        Console.WriteLine($"{dragon1.Name} is now angry and flying in the air, breathing fire!");
                        break; // Proceed to ice arrow stage
                    case "2":
                        Console.WriteLine($"You've chosen to use the {hero1.Weapon2}. This will not work here. Please try again!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            } while (actionChoice != "1");

            // Stage 2: Use ice arrow
            Console.WriteLine($"How do you wish to proceed?");
            Console.WriteLine();
            Console.WriteLine($"1. Use the {hero1.Weapon1} with an {hero1.ArrowType2}.");
            Console.WriteLine($"2. Use the {hero1.Weapon2}.");
            Console.WriteLine();

            do
            {
                Console.Write("Enter the number of your choice (1 or 2): ");
                actionChoice = Console.ReadLine()?.Trim();

                switch (actionChoice)
                {
                    case "1":
                        Console.WriteLine($"You've chosen to use the {hero1.Weapon1} with an {hero1.ArrowType2}. {allies1.Name} and {knight1.Name} can now join the battle!");
                        Console.WriteLine();
                        Console.WriteLine($"{dragon1.Name}'s fire is out!");
                        break; // Proceed to final move stage
                    case "2":
                        Console.WriteLine($"You've chosen to use the {hero1.Weapon2}. This will not work here. Please try again!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            } while (actionChoice != "1");

            // Final Move: Call in allies, knight, and use magical sword or use incorrect option
            Console.WriteLine($"Final Move: What do you choose?");
            Console.WriteLine($"1. Call in your allies {allies1.Name} and your knight {knight1.Name}, and use the {hero1.Weapon2}!");
            Console.WriteLine($"2. Use the {hero1.Weapon1}?");
            Console.WriteLine();

            Console.Write("Enter the number of your choice (1 or 2): ");
            actionChoice = Console.ReadLine()?.Trim();

            switch (actionChoice)
            {
                case "1":
                    Console.WriteLine($"You successfully defeated {dragon1.Name} and saved Princess {princess1.Name}! Peace has been restored to the Kingdom!");
                    success = true;
                    break; // End game
                case "2":
                    Console.WriteLine($"You decided to use the {hero1.Weapon1}. This will not work here. Game Over!");
                    break; // End game
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (!success)
            {
                Console.WriteLine($"Unfortunately, {dragon1.Name} was not defeated this time. The kingdom remains in peril.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
