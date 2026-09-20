using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace MyProjectName{
    
    public class MainProgram
    {
        public static void Main(String[] args){
            Console.Clear();
            Console.Write("Enter your age: ");      
            int inputtedAge = int.Parse(Console.ReadLine());

            bool ValidAge = VerifyUser.UserIdentified(inputtedAge);
            if (ValidAge)
            {
                Console.Clear();
                Console.WriteLine("Veritification success!");
                MainMenu gameMenu = new MainMenu();
                gameMenu.DisplayMenu();
                gameMenu.UserInput();
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
        }
    }
    
    class VerifyUser
    {           
        public static bool UserIdentified(int age)
        {
            if(age < 18)
            {
                Console.WriteLine("You are minor");
                return false;
            }
            return true;
            
        }
    }
    class MainMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("SELECT THE FOLLOWING");
            Console.WriteLine("1. START");
            Console.WriteLine("2. EXIT");
            Console.Write("SELECT: ");
        }

        public void UserInput()
        {
            String? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    GameRun start = new GameRun();
                    start.AppStart();
                    break;
                case "2":
                    Console.WriteLine("app exiting");
                    Environment.Exit(0); 
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }

        class GameRun
        {
            public void AppStart()
            {
                Random random = new Random();
                
                int secretNumber = random.Next(1, 101);
                int guess = 0;
                int countdown = 5;

                Console.WriteLine("GUESS THE NUMBER BY MUTIPLICATION (" + countdown + " Limit)");
                
                while (guess != secretNumber && countdown >= 0)
                {
                    Console.Write("Enter your guess number: ");
                    String? input = Console.ReadLine();
                    guess = int.Parse(input);

                    if(guess > secretNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Too high");
                        Console.WriteLine("Remaining limit " + countdown);
                    }
                    else if (guess < secretNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Too low try again");
                        Console.WriteLine("Remaining limit " + countdown);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Congratulations you guessed it!");
                        Console.WriteLine("Terminating program......");

                    }
                    countdown--;
                }
                    
            }
            
        }

    }
}
