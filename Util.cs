using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MenuConsoleApp
{
    public static class Util
    {
        internal static string CheckString(string prompt, IUI ui)
        {
            bool success = false;
            var answer = "";

            do
            {
                ui.Print(prompt);
                answer = ui.GetInput();
                answer = Regex.Replace(answer, @"\s+", " ");
                var split = answer.Split(" ");
                if (split.Length < 1)
                {
                    string pattern = $"^[a-zåäöA-ZÅÄÖ]+$";
                    Regex rg = new Regex(pattern);
                    if (!rg.Match(answer).Success)
                    {
                        ui.Write("ordet får bara innehålla bokstäver.");
                        success = false;
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(answer))
                        {
                            ui.Write("Du måste skriva något");
                        }
                        else
                        {
                            success = true;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < split.Length; i++)
                    {
                        var sentence = split[i];
                        string pattern = $"^[a-zåäöA-ZÅÄÖ]+$";
                        Regex rg = new Regex(pattern);
                        if (!rg.Match(sentence).Success)
                        {
                            ui.Write("orden får bara innehålla bokstäver.");
                            success = false;
                        }
                        else
                        {
                            success = true;
                        }
                    }
                }
                
             
     

   

            } while (!success);

            return answer;
        }
        internal static string JustCheckString(string prompt, IUI ui)
        {
            bool success = false;

            do
            { 
                if (string.IsNullOrWhiteSpace(prompt))
                {
                    ui.Write("Du måste skriva något");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return prompt;
        }
        internal static int CheckInt(string promt, IUI ui)
        {
            bool success = false;
            int answer;

            do
            {
                string input = JustCheckString(promt, ui);
                success = int.TryParse(input, out answer) && answer > 0;

                if (!success)
                    ui.Write("Fel, du måste skriva en siffra");

            } while (!success);

            return answer;
        }
    }
}
