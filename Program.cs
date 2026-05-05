
using System;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            var priskalkylator = new Ovn2_FlowControl.PrisKalkylator();
            var textFunktioner = new Ovn2_FlowControl.TextFunktioner();

            while (running)
            {
                Console.WriteLine("Välkommen till huvudmenyn.");
                Console.WriteLine("Skriv en siffra för att välja funktion.");
                Console.WriteLine("0 = Avsluta");
                Console.WriteLine("1 = Ungdom eller pensionär");
                Console.WriteLine("2 = Pris för sällskap");
                Console.WriteLine("3 = Upprepa tio gånger");
                Console.WriteLine("4 = Det tredje ordet");
                Console.Write("Ditt val: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        running = false;
                        Console.WriteLine("Programmet avslutas.");
                        break;

                    case "1":
                        priskalkylator.UngdomEllerPensionar();
                        break;

                    case "2":
                        priskalkylator.PrisForSallskap();
                        break;

                    case "3":
                        textFunktioner.UpprepaTioGanger();
                        break;

                    case "4":
                        textFunktioner.DetTredjeOrdet();
                        break;

                    default:
                        Console.WriteLine("Felaktig input, välj 0-4.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

