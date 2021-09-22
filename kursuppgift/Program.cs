using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace kursuppgift
{
    class Program
    {
        public static bool inputValidity = true;
        static void Main(string[] args)
        {

            
            string userInput ="";
            Functions functions = new Functions();

            while (inputValidity == true)
            {
                Functions.printOutList();

                userInput = Console.ReadLine();
                switch (userInput)
            {
                case "0":
                        Functions.closeApp();

                    break;
                case "1":
                        Console.Clear();
                        functions.fn1();
                    break;

                case "2":
                        Console.Clear();
                        functions.fn2();
                     break;

                case "3":
                        Console.Clear();
                        functions.fn3();
                     break;
                 case "4":
                        Console.Clear();
                        functions.fn4();
                     break;

                case "5":
                        Console.Clear();
                        functions.fn5();
                        break;

                case "6":
                        Console.Clear();
                        functions.fn6();
                        break;
                
                case "7":
                        Console.Clear();
                        functions.fn7();
                        break;
                
                case "8":
                        Console.Clear();
                        functions.fn8();
                        break;
                
                case "9":
                        Console.Clear();
                        functions.fn9();
                        break;
                
                case "10":
                        Console.Clear();
                        functions.fn10();
                        break;
                
                case "11":
                        Console.Clear();
                        functions.fn11();
                        break;
                
                case "12":
                        Console.Clear();
                        functions.fn12();
                        break;

                 case "13":
                        Console.Clear();
                        functions.fn13();
                        break;
                
                case "14":
                        Console.Clear();
                        functions.fn14();
                        break;

                 case "15":
                        Console.Clear();
                        functions.fn15();
                        break;

                case "16":
                        Console.Clear();
                        Console.WriteLine("-+-+-+- Testing Funktion no.16 -+-+-+-\n");
                        string character, opponent;
                        Console.Write("Ange ditt karaktärsnamn : ");
                        character = Console.ReadLine();
                        Console.Write("Ange namnet på motståndaren : ");
                        opponent= Console.ReadLine();
                        ComparisonGame comparisonGame1 = new ComparisonGame();
                        ComparisonGame comparisonGame2 = new ComparisonGame();

                        Console.Write("------------------------ " + character+ " -------------------------\n");
                        comparisonGame1.setRandomValues();
                        Console.Write("----------------------------------------------------------------\n\n");
                        Console.Write("------------------------- " + opponent+ " -------------------------\n");
                        comparisonGame2.setRandomValues();
                        Console.Write("----------------------------------------------------------------\n");

                        break;

                    default:
                        Console.Clear();
                        Console.Beep();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel val !!, skriv ett tal mellan 1 till 16 eller 0 för att avsluta programmet, Försök igen!!");
                        Console.BackgroundColor = default;
                        
                        break;


                }
            }

         //   Console.ReadLine();
        }
    }
}
