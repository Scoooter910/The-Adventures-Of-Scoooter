using System;
using System.Collections.Generic;
using System.Linq;

using The_Adventures_of_Scoooter;

bool playAgain;
do
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Beep(659, 500);
    Console.Beep(880, 1000);
    Console.Beep(659, 500);
    Console.Beep(784, 500);
    Console.Beep(880, 1000);
    Console.Beep(698, 500);
    Console.Beep(587, 500);
    Console.Beep(523, 1000);
    Console.Beep(698, 500);
    Console.Beep(587, 500);
    Console.Beep(523, 1000);
    Console.Beep(659, 500);

    Dragon dragon1 = new Dragon { Name = "PABE", MonsterAttack = "breathing fire" };
    Hero hero1 = new Hero { Name = "", Weapon1 = "bow and Arrow", Weapon2 = "Magical Sword", ArrowType1 = "fire Arrow", ArrowType2 = "ice arrow" };
    Princess princess1 = new Princess { Name = "Penelope" };
    Allies allies1 = new Allies { Name = "Myrtle and Girdle", FlyAbility = "shoot bird seed" };
    Knight knight = new Knight { Dog = "Dog", Cat = "Cat" };

    Console.Title = "NOSTALGIC ADVENTURES I";

    Console.WriteLine("WELCOME TO NOSTAGLIC ADVENTURES I");

    Console.WriteLine("Please enter your Hero name:");
    string userName = Console.ReadLine()?.ToLower(); ;
    Console.ReadKey();

    Console.WriteLine($"Please choose your animal companion: A {knight.Dog} named {knight.DogName} or a {knight.Cat} named {knight.CatName}  " +
                      $"Tip: " +
                      $"Each companion has a different Special Ability. " +
                      $"Please type {knight.Dog} or {knight.Cat}.");

    string userKnight = Console.ReadLine()?.ToLower();
    if (userKnight == "dog")
    {
        Console.WriteLine($"Your companion is a Dog named {knight.DogName} with a {knight.DogSpecialAbility} ability! ");
    }
    else if (userKnight == "cat")
    {
        Console.WriteLine($"Your companion is a Cat named {knight.CatName} with a {knight.CatSpecialAbility} ability! ");
    }

    Console.WriteLine($"Once upon a time in a kingdom far away, there was a legendary Hero named {userName}.");
    Console.WriteLine($"There was also a captured Princess named {princess1.Name}.");
    Console.WriteLine($"As legend goes...the kingdom, and {princess1.Name} were threatened by a ferocious dragon named {dragon1.Name}.");
    Console.WriteLine($"In order to save {princess1.Name}, you must help {hero1.Name} defeat {dragon1.Name} and restore peace to the kingdom.");
    Console.WriteLine($"You will not fight this battle alone. You have allies named {allies1.Name} and your companion to assist \nyou on this journey...");
    Console.WriteLine();


    Console.WriteLine("Please type 'start' to begin:");
    string userInput2;
    do
    {
        userInput2 = Console.ReadLine()?.Trim().ToLower();
    } while (userInput2 != "start");

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
                Console.WriteLine($"You've chosen to use the {hero1.Weapon1} with an {hero1.ArrowType2}. {allies1.Name} and {knight.Dog} can now join the battle!");
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

    // Final Move: Call in allies, companion, and use magical sword or use incorrect option
    Console.WriteLine($"Final Move: What do you choose?");
    Console.WriteLine($"1. Call in your allies {allies1.Name} and your companion, and use the {hero1.Weapon2}?");
    Console.WriteLine($"2. Use the {hero1.Weapon1}?");
    Console.WriteLine();

    Console.Write("Enter the number of your choice (1 or 2): ");
    actionChoice = Console.ReadLine()?.Trim();

    switch (actionChoice)
    {
        case "1":
            Console.WriteLine($"You successfully defeated {dragon1.Name} and saved Princess {princess1.Name}! Peace has been restored to the Kingdom!");
            PlayGameVictorySound();
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
        PlayGameOverSound();
    }

    static void PlayGameOverSound()
    {
        Console.Beep(500, 200);
        Console.Beep(400, 200);
        Console.Beep(300, 400);
    }

    static void PlayGameVictorySound()
    {
        Console.Beep(1000, 200);
        Console.Beep(1100, 200);
        Console.Beep(1200, 200);
        Console.Beep(1300, 200);
        Console.Beep(1400, 200);
    }

    Console.WriteLine("Do you want to play again? (yes/no)");
    string playAgainInput = Console.ReadLine()?.ToLower();
    playAgain = (playAgainInput == "yes");

} while (playAgain);
Console.WriteLine("Thanks for playing!");

        