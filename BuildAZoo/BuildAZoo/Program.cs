using BuildAZoo.Classes;
using System;

namespace BuildAZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare placeholder variables
            string menuSelection = "";

            // Loop until the user enters the "5" key to exit the application
            do
            {
                // Prompt user to select an option from the menu
                PrintMainMenu();
                menuSelection = Console.ReadLine();
                Console.Clear();

                switch (menuSelection)
                {
                    case "1": // Display Vampire Bat Class
                        DisplayVampireBat();

                        PromptToReturnToMainMenu();
                        break;
                    case "2":// Display Batman Class
                        DisplayBatman();

                        PromptToReturnToMainMenu();
                        break;
                    case "3": // Display Black Widow Class
                        DisplayBlackWidow();

                        PromptToReturnToMainMenu();
                        break;
                    case "4": // Display Iguana Class
                        DisplayIguana();

                        PromptToReturnToMainMenu();
                        break;
                    case "5": // Exits the Program
                        Environment.Exit(0);
                        break;
                    default: // Handles cases where user doesn't enter a valid menu option
                        Console.WriteLine("That did not match one of the menu options. Try again.\n");
                        break;
                }
            } while (menuSelection != "5");
        }

        // Method which prints the main menu to the console window.
        public static void PrintMainMenu()
        {
            Console.WriteLine(
                    "Select an option from the menu below:\n" +
                    "1) Display properties and methods of the Vampire Bat Class\n" +
                    "2) Display properties and methods of the Batman Class\n" +
                    "3) Display properties and methods of the Black Widow Class\n" +
                    "4) Display properties and methods of the Iguana Class\n" +
                    "5) Exit Program");
        }

        // Method which prompts the user to press any key to return to the main menu. Clears the console window.
        public static void PromptToReturnToMainMenu()
        {
            Console.Write("Press any key to return to main menu...");
            Console.ReadKey();
            Console.Clear();
        }

        // Method which prints out several properties and methods of the Vampire Bat Class
        public static void DisplayVampireBat()
        {
            Console.WriteLine(
                    "Here is a Vampire Bat, it is derived from the " +
                    "Animal -> Mammal -> Bat Classes in order.\n");

            Console.WriteLine(
                    "The Vampire Bat inherets all of the properties and methods accociated with those Classes.\n" +
                    "It also Implements the IBeEvil Interface and inherets the ICanFly Interface from the Bat Class.\n");

            VampireBat vampBat = new VampireBat();

            Console.WriteLine($"How a Vampire Bat eats: {vampBat.Eat(vampBat.Diet)}\n");

            Console.WriteLine($"What does a Vampire Bat wear: {vampBat.BodyCovering}\n");

            Console.WriteLine($"What sound does a Vampire Bat make: {vampBat.MakeSound(vampBat.Sound)}\n");

            Console.WriteLine(
                    $"Is it true that a Vampire Bat has inner ear bones: {vampBat.HasEarBones}\n");

            Console.WriteLine($"How does a Vampire Bat fly: {vampBat.HowIFly()}\n");

            Console.WriteLine($"Which phobias does a Vampire Bat cause: {vampBat.PhobiaCaused}\n");
        }

        // Method which prints out several properties and methods of the Batman Class
        public static void DisplayBatman()
        {
            Console.WriteLine(
                    "Here is Batman, he is derived from the " +
                    "Animal -> Mammal -> Bat Classes in order.\n");

            Console.WriteLine(
                    "Batman inherets all of the properties and methods accociated with those Classes.\n" +
                    "He also inherets the ICanFly Interface from the Bat Class.\n");

            Batman bruceWayne = new Batman();

            Console.WriteLine($"How Batman eats: {bruceWayne.Eat(bruceWayne.Diet)}\n");

            Console.WriteLine($"What does Batman wear: {bruceWayne.BodyCovering}\n");

            Console.WriteLine($"What sound does Batman make: {bruceWayne.MakeSound(bruceWayne.Sound)}\n");

            Console.WriteLine(
                    $"Is it true that Batman has inner ear bones: {bruceWayne.HasEarBones}\n");

            Console.WriteLine($"How does Batman fly: {bruceWayne.HowIFly()}\n");
        }

        // Method which prints out several properties and methods of the Black Widow Class
        public static void DisplayBlackWidow()
        {
            Console.WriteLine(
                    "Here is a Black Widow, it is derived from the " +
                    "Animal -> Bug -> Spider Classes in order.\n");

            Console.WriteLine(
                    "The Black Widow inherets all of the properties and methods accociated with those Classes.\n" +
                    "It also Inherets the IBeEvil and ICanFly Interfaces from the Spider Class.\n");

            BlackWidow blackWidow = new BlackWidow();

            Console.WriteLine($"How a Black Widow eats: {blackWidow.Eat(blackWidow.Diet)}\n");

            Console.WriteLine($"What does a Black Widow wear: {blackWidow.BodyCovering}\n");

            Console.WriteLine($"What sound does a Black Widow make: {blackWidow.MakeSound(blackWidow.Sound)}\n");

            Console.WriteLine(
                    $"Can Black Widows see you: {blackWidow.LookAround()} All {blackWidow.NumberOfEyes} of them!\n");

            Console.WriteLine(
                    $"Is it true that a Black Widow is a creepy, crawly bug: {blackWidow.IsCreepyCrawly}\n");
            
            Console.WriteLine($"How does a Black Widow fly: {blackWidow.HowIFly()}\n");

            Console.WriteLine($"Which phobias does a Black Widow cause: {blackWidow.PhobiaCaused}\n");
        }

        // Method which prints out several properties and methods of the Iguana Class
        public static void DisplayIguana()
        {
            Console.WriteLine(
                    "Here is an Iguana, it is derived from the " +
                    "Animal -> Reptile -> Lizard Classes in order.\n");

            Console.WriteLine(
                    "The Iguana inherets all of the properties and methods accociated with those Classes.\n");

            Iguana iguana = new Iguana();

            Console.WriteLine($"How an Iguana eats: {iguana.Eat(iguana.Diet)}\n");

            Console.WriteLine($"What does an Iguana wear: {iguana.BodyCovering}\n");

            Console.WriteLine($"What sound does an Iguana make: {iguana.MakeSound(iguana.Sound)}\n");

            Console.WriteLine(
                    $"What sound does an Iguana make after turning into Godzilla: {iguana.BecomeGodzilla()}\n");

            Console.WriteLine($"Are Iguanas cold blooded: {iguana.ColdBlooded}\n");

            Console.WriteLine($"Do Iguanas like the sun: {iguana.HeatInSun(iguana.ColdBlooded)}\n");
        }
    }
}
