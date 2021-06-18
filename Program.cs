using System;

namespace MenuConsoleApp
{
    class Program
    {
        static IUI ui = new ConsoleUI();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                UserInput();
                MainMenu();
            } while (true);
        }

        private static void UserInput()
        {
            ui.Write("Du har kommit till huvudmenyn och du kan välja olika kommandon och tryck sedan enter.");
            ui.Write("1 Välj biobokning");
            ui.Write("3 Välj looptest");
            ui.Write("4 Välj Se det tredje ordet i en mening");
            ui.Write("0. Avsluta\r\n");
            ui.Print("Skriv in valfri siffra mellan 0-3, tryck sedan Enter knappen: ");
        }


        static void MainMenu()
        {
            String myoption = String.Empty;
            myoption = ui.GetInput();

            switch (myoption)
            {
                default:
                
                    ui.Write("Ange en korrekt siffra, tryck valfri tangent för att gå till huvudmenyn.");
                    ui.GetKeyInput();
                    break;
                case "0":
                    ui.Write("Är det säkert att du vill avsluta? skriv j/n, tryck sedan Enter knappen:");
                    string exit = ui.GetInput();

                    exit.ToLower();
                    if (exit == "j")
                    {
                        Environment.Exit(-1);
                        break;
                    }
                    else
                    {
                        Main(null);
                        break;
                    }

                case "1":
                    ui.Write("1 Välj biobokning för 1 person");
                    ui.Write("2 Välj biobokning för sällskap");
                    ui.Write(" ");
                    ui.Print("En eller flera personer? tryck sedan Enter: ");
                    myoption = ui.GetInput();
                    int option = 0; 
                    option = Util.CheckInt(myoption, ui);
                    MovieBooking.CheckPriceForMovie(option);
                    break;
                case "2":
                    Looptest();
                    break;
                case "3":
                    ThirdWord();
                    break;
            }
        }

        private static void Looptest()
        {
            string word = Util.CheckString("Skriv ett ord: ", ui);

            for (int i = 0; i < 10; i++)
            {
                ui.Print($" {i + 1}. {word}");
            }
            ui.Write(" ");
            ui.Write(" ");
            ui.Write("Tryck valfri tangent för att gå till huvudmenyn");
            ui.GetKeyInput();
        }

        private static void ThirdWord()
        {
            var sentence= Util.CheckString("Skriv en mening med minst tre ord: ", ui);
            
            var split = sentence.Split(" ");
            if(split.Length < 3)
            {
                ui.Write("Du måste ange minst 3 ord");
                ui.Write(" ");
                ThirdWord();
            }
            else
            {
                string thirdword = split[2];
                ui.Write(thirdword);
                ui.Write(" ");
                ui.Write("Tryck valfri tangent för att gå tillbaka till huvudmenyn.");
                ui.GetKeyInput();
            }
        }
    }
}

