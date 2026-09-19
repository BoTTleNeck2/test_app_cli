using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace test{
    
    public class MainProgram
    {
        public static void Main(String[] args){
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your age: ");       

            int inputtedAge = int.Parse(Console.ReadLine());

            bool ValidAge = VerifyUser.UserIdentified(inputtedAge);

            if (ValidAge)
            {
                Console.Clear();
                Console.WriteLine("Veritification success! Mr. " + name);
                MainMenu gameMenu = new MainMenu();
                gameMenu.DisplayMenu();
                gameMenu.UserInput();
            }
            else
            {
                Console.WriteLine("Hey Mr. " + name + " Access denied");
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
            String choice = Console.ReadLine();

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
                Console.WriteLine("SOON!!");
            }
            
        }

    }
}
