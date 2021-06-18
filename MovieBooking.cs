using System;
using System.Collections.Generic;
using System.Text;

namespace MenuConsoleApp
{
    public static class MovieBooking
    {
        static IUI ui = new ConsoleUI();
        internal static void CheckPriceForMovie(int option)
        {  
            if(option == 1)
            {
                ui.Print("Ange din ålder: ");

                int age = Util.CheckInt(ui.GetInput(), ui);

                int price = CheckPrice(age);
                if(price == 0)
                {
                    ui.Write($"{PriceCategory.Gratis.ToString()} {price} kr");
                }
                else if (price == 80)
                {
                    ui.Write($"{ PriceCategory.Ungdomspris.ToString()}  {price} kr");
                }
                else if (price == 90)
                {
                    ui.Write($"{ PriceCategory.Pensionärspris.ToString()}  {price} kr");
                }
                else
                {
                    ui.Write($" { PriceCategory.Standarpris.ToString()} {price} kr");
                }

                ui.Write(" ");
                ui.Write("Tryck valfri tangent för att gå till huvudmenyn");
                ui.GetKeyInput();

            }
            else if(option == 2)
            {
                ui.Write("Hur många är ni i sällskapet: ");
                string input = ui.GetInput();
                int numberOfPeople = Util.CheckInt(input, ui);
                int totalprice = 0;

                for (int i = 1; i <= numberOfPeople; i++)
                {
                    ui.Write("Vilken ålder har person " + i + ":");
                    string year = ui.GetInput();
                    int age = Util.CheckInt(year, ui);
                    totalprice += CheckPrice(age);
                }

                ui.Write(" ");
                ui.Write($"Det är {numberOfPeople} personer och det samalagda priset är: {totalprice} kr");
                ui.Write("Tryck valfri tangent för att gå till huvudmenyn");
                ui.GetKeyInput();
            }
        }



        private static int CheckPrice(int age)
        {
            if(age < ((int)AgeCategory.Barn) || age > ((int)AgeCategory.Senior))
            {
                return 0;
            }
            else if(age < ((int)AgeCategory.Ungdom))
            {
                return 80;
            }
            else if(age >= ((int)AgeCategory.Pensionär))
            {
                return 90;
            }
            else
            {
                return 120;
            }
        }
    }
}
