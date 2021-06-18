using System;

namespace MenuConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String myoption = String.Empty;
            do
            {
                UserInput(myoption);
                MainMenu(myoption);
            } while (true);
        }

        private static void UserInput(String myoption)
        {
            Console.WriteLine("Du har kommit till huvudmenyn och du kan välja olika kommandon och tryck sedan enter.");
            Console.WriteLine("1 Välj biobokning");
            Console.WriteLine("2 Välj looptest");
            Console.WriteLine("3 Välj Se det tredje ordet i en mening");
            Console.WriteLine("4 Välj Se det tredje ordet i en mening");
            Console.WriteLine("0. Avsluta\r\n");
            Console.Write("Skriv in valfri siffra mellan 0-6, tryck sedan Enter knappen: ");
            myoption = Console.ReadLine();
            //int.TryParse(myoption, out option);
            MainMenu(myoption);

            // 2.Skapa skalet till en Switch-sats som till en början har Två Cases.
            // Ett för ”0” somstänger ner programmet och ett default som berättar att det är felaktig input.
            // 3.Skapa en ​oändlig iteration, ​alltså något som inte tar slut innan vi säger till att denska ta slut.
            // Detta löser ni med att skapa en egen bool med tillhörande while-loop.
            // 4.Bygg ut menyn med val att exekvera de övriga övningarna.
        }


        static void MainMenu(string myoption)
        {

            bool continuestatus = true;
            // While to make a loop to make many or possibility to make infinte quantity of choices.
            while (continuestatus)
            {
                // Switch to handle different choises of the menu.
                switch (myoption)
                {
                    default:
                        Console.WriteLine("Ange en korrekt siffra");
                        continuestatus = true;
                        break;
                    case "0":
                        Console.WriteLine("Är det säkert att du vill avsluta? skriv j/n, tryck sedan Enter knappen:");
                        string exit = Console.ReadLine();

                        exit.ToLower();
                        if (exit == "j")
                        {
                            continuestatus = false;
                            Environment.Exit(1);
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Main(null);
                            continuestatus = true;
                            break;
                        }

                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                }

            }

        }


            //Menyval 1: Ungdom eller pensionärFör att exemplifiera ​if-satser​ skall ni implementera,
            //på uppdrag av en teoretisk lokal bio,ett program som kollar om en person är pensionär eller ungdom vid angiven ålder.
            //För attkomma till denna funktion skall ett ​case ​i huvudmenyn skapas för ”1”, detta skall ävenframgå i texten som förklarar menyn.

        }
    }

