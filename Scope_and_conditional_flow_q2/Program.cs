namespace Scope_and_conditional_flow_q2;

class Program
{
    static void Main(string[] args)
    {
        SwichCharacter();
        // call function for Switch-case demo
    }
    
    // Question 1: Basic Switch Case
    // Write a C# program that prompts the user to enter a number between 1 and 3. Using a switch-case statement,
    // display a message based on the number entered. If the number is 1, print "One"; if the number is 2, print "Two"; if the number is 3, print "Three".
    // If the number does not match any of these, display a default message.
    // Hint: Use Console.ReadLine() to get user input and Convert.ToInt32() to convert the input to an integer.
    static void switchCase1To3()
    {
        Console.Write("Enter number (1 - 3): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
        }
    }

    //---------------------------------------------------------------------
    // Question 2: Game Character Selection
    // In a game, the player can select a character class using numbers 1 to 3.
    // Write a C# program that prompts the player to choose a character class.
    // Based on the chosen number, display a message indicating the selected class: 1 for Warrior, 2 for Mage, and 3 for Archer.
    // If the number does not match any of these, display a default message.
    // Hint: Utilize switch-case statements to handle different cases of character selection.
    static void SwichCharacter()
    {

        Console.Write("Enter number (1 - 3): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Warrior");
                break;
            case 2:
                Console.WriteLine("Mage");
                break;
            case 3:
                Console.WriteLine("Archer");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }

    //---------------------------------------------------------------------
    // Question 3: Directional Movement
    // In a game, the player can move in four cardinal directions: North, South, East, and West.
    // Write a C# program that prompts the player to enter a direction using numbers 1 to 4.
    // Based on the chosen number, display a message indicating the direction: 1 for North, 2 for South, 3 for East, and 4 for West.
    // If the number does not match any of these, display a default message.
    // Hint: Implement a switch-case statement to handle different directional inputs.
    static void SwitchDirectionalMove()
    {
        Console.Write("Enter Number(1,2,3,4) ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("North");
                break;
            case 2:
                Console.WriteLine("South");
                break;
            case 3:
                Console.WriteLine("East");
                break;
            case 4:
                Console.WriteLine("West");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }

    //---------------------------------------------------------------------
    // Question 4: Day of the Week
    // Write a C# program that prompts the user to enter a number between 1 and 7 representing a day of the week.
    // Use a switch-case statement to display the name of the corresponding day.
    // For example, if the user enters 1, print "Monday"; if 2, print "Tuesday", and so on. If the number does not match any of these, display a default message.
    // Hint: Map each number input to a specific day of the week using a switch-case statement.
    static void SwitchDayOfWeek()
    {
        Console.Write("Enter number representing a day of the week (1-7): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }

    //---------------------------------------------------------------------
    // Question 5: Weapon Selection
    // In a game, the player can select a weapon using numbers 1 to 4.
    // Write a C# program that prompts the player to choose a weapon. Based on the chosen number, display a message indicating the selected weapon: 1 for Sword, 2 for Bow, 3 for Staff, and 4 for Axe.
    // If the number does not match any of these, display a default message.
    // Hint: Use switch-case statements to handle different weapon choices.
    static void SwithWeaponSelection()
    {
        Console.Write("Enter number weapon (1-4): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Sword");
                break;
            case 2:
                Console.WriteLine("Bow");
                break;
            case 3:
                Console.WriteLine("Staff");
                break;
            case 4:
                Console.WriteLine("Axe");
                break;
            default:
                Console.WriteLine("Gun");
                break;
        }
    }
    //---------------------------------------------------------------------
    // Question 6: Elemental Magic
    // In a fantasy game, the player can cast elemental magic spells using numbers 1 to 5.
    // Write a C# program that prompts the player to select a magic spell. Based on the chosen number, display a message indicating the selected spell element: 1 for Fire, 2 for Water, 3 for Earth, 4 for Air, and 5 for Lightning.
    // If the number does not match any of these, display a default message.
    // Hint: Implement a switch-case statement to handle different spell selections.
    static void SwithElementalMagic()
    {
        Console.Write("Enter number weapon (1-5): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Fire");
                break;
            case 2:
                Console.WriteLine("Water");
                break;
            case 3:
                Console.WriteLine("Earth");
                break;
            case 4:
                Console.WriteLine("Air");
                break;
            case 5:
                Console.WriteLine("Lighting");
                break;
            default:
                break;
        }
    }

    //---------------------------------------------------------------------
    // Question 7: Menu Navigation
    // Write a C# program that simulates a menu navigation system for a game.
    // The user can enter numbers 1 to 4 to navigate through different menu options: 1 for Start Game, 2 for Options, 3 for Load Game, and 4 for Exit.
    // If the number does not match any of these, display a default message.
    // Hint: Utilize switch-case statements to handle user input and navigate between menu options.
    static void SwitchMenyNavigate()
    {
        Console.Write("Enter number weapon (1-5): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Start game");
                break;
            case 2:
                Console.WriteLine("Option");
                break;
            case 3:
                Console.WriteLine("Load game");
                break;
            case 4:
                Console.WriteLine("Exit");
                break;
            default:
                break;
        }
    }

    //---------------------------------------------------------------------
    // Question 8: NPC Interaction
    // In an RPG game, the player can interact with non-player characters (NPCs) using numbers 1 to 3.
    // Write a C# program that prompts the player to choose an interaction option with an NPC. Based on the chosen number, display a message indicating the selected interaction: 1 for Talk, 2 for Trade, and 3 for Quest.
    // If the number does not match any of these, display a default message.
    // Hint: Implement a switch-case statement to handle different interaction options with NPCs.
    static void SwitchNPCOption()
    {
        Console.Write("Enter number Option (1-3): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Talk");
                break;
            case 2:
                Console.WriteLine("Trade");
                break;
            case 3:
                Console.WriteLine("Quit");
                break;
            default:
                break;
        }
    }
    //---------------------------------------------------------------------
    // Question 9: Puzzle Solutions
    // In a puzzle-solving game, the player can choose from different solutions using numbers 1 to 5.
    // Write a C# program that prompts the player to select a solution for a puzzle. Based on the chosen number, display a message indicating the selected solution option.
    // If the number does not match any of these, display a default message.
    // Hint: Use switch-case statements to handle different puzzle solution choices.
    static void SwitchPuzzleSolution()
    {
        Console.Write("Enter number Option (1-5): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Puzzle 1");
                break;
            case 2:
                Console.WriteLine("Puzzle 2");
                break;
            case 3:
                Console.WriteLine("Puzzle 3");
                break;
            case 4:
                Console.WriteLine("Puzzle 4");
                break;
            case 5:
                Console.WriteLine("Puzzle 5");
                break;
            default:
                break;
        }
    }
    //---------------------------------------------------------------------
    // Question 10: Dialogue Choices
    // Write a C# program that simulates dialogue choices in a game. The player can select dialogue options using numbers 1 to 4.
    // Based on the chosen number, display a message indicating the selected dialogue choice. If the number does not match any of these, display a default message.
    // Hint: Implement switch-case statements to handle different dialogue options presented to the player.
    static void DialogueChoice()
    {
        Console.Write("Enter number Option (1-4): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Hello");
                break;
            case 2:
                Console.WriteLine("Kids are smart these days!");
                break;
            case 3:
                Console.WriteLine("What a amazing thing");
                break;
            case 4:
                Console.WriteLine("Goods! Let's go");
                break;
            default:
                break;
        }
    }
    //---------------------------------------------------------------------
    // Question 11: Crafting Items
    // In a crafting system, the player can select crafting recipes using numbers 1 to 3.
    // Write a C# program that prompts the player to choose a crafting recipe.
    // Based on the chosen number, display a message indicating the selected recipe: 1 for Potion, 2 for Weapon, and 3 for Armor. If the number does not match any of these, display a default message.
    // Hint: Utilize switch-case statements to handle different crafting recipe selections.
    static void CraftingItems()
    {
        Console.Write("Enter number Option (1-3): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Potion");
                break;
            case 2:
                Console.WriteLine("Weapon");
                break;
            case 3:
                Console.WriteLine("Armor");
                break;
            default:
                break;
        }
    }
    //---------------------------------------------------------------------
    // Question 12: Scene Selection
    // Write a C# program that simulates scene selection in a game.
    // The player can choose scenes using numbers 1 to 5. Based on the chosen number, display a message indicating the selected scene.
    // If the number does not match any of these, display a default message.
    // Hint: Implement switch-case statements to handle different scene selections.
    static void ScenceSelection()
    {
        Console.Write("Enter number Option (1-5): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Erangel");
                break;
            case 2:
                Console.WriteLine("Miramar");
                break;
            case 3:
                Console.WriteLine("Taego");
                break;
            case 4:
                Console.WriteLine("Rondo");
                break;
            case 5:
                Console.WriteLine("Vikendi");
                break;
            default:
                Console.WriteLine("Sanhok");
                break;
        }
    }
    //---------------------------------------------------------------------
    // Question 13: Quest Progression
    // In an adventure game, the player can progress through quests using numbers 1 to 4.
    // Write a C# program that prompts the player to select a quest. Based on the chosen number, display a message indicating the selected quest.
    // If the number does not match any of these, display a default message.
    // Hint: Use switch-case statements to handle different quest selections and progression
    static void QuestProgression()
    {
        Console.Write("Enter number Option (1-4): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Progress 1");
                break;
            case 2:
                Console.WriteLine("Progress 2");
                break;
            case 3:
                Console.WriteLine("Progress 3");
                break;
            case 4:
                Console.WriteLine("Prorgress 4");
                break;
            default:
                Console.WriteLine("Restart");
                break;
        }
    }

    //---------------------------------------------------------------------
    // Question 14: Potion Brewing
    // In an alchemy system, the player can brew potions using numbers 1 to 3.
    // Write a C# program that prompts the player to choose a potion to brew. Based on the chosen number, display a message indicating the selected potion: 1 for Health Potion, 2 for Mana Potion, and 3 for Stamina Potion.
    // If the number does not match any of these, display a default message.
    // Hint: Implement switch-case statements to handle different potion brewing choices.
    static void PotionBrewing()
    {
        Console.Write("Enter number Option (1-3): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Health Potion");
                break;
            case 2:
                Console.WriteLine("Mana Potion");
                break;
            case 3:
                Console.WriteLine("Stamina Potion");
                break;
            default:
                Console.WriteLine("Restart");
                break;
        }
    }



    //---------------------------------------------------------------------
    // Question 15: Platform Movement
    // In a platformer game, the player can move the character using numbers 1 to 4 for directional controls.
    // Write a C# program that prompts the player to enter a movement direction. Based on the chosen number, display a message indicating the movement direction: 1 for Left, 2 for Right, 3 for Jump, and 4 for Crouch.
    // If the number does not match any of these, display a default message.
    // Hint: Utilize switch-case statements to handle different movement directions, including a default case.
    static void PlatformMovement()
    {
        Console.Write("Enter number Option (1-4): ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Left");
                break;
            case 2:
                Console.WriteLine("Right");
                break;
            case 3:
                Console.WriteLine("Jump");
                break;
            case 4:
                Console.WriteLine("Crouch");
                break;
            default:
                Console.WriteLine("Stay");
                break;
        }
    }




}
