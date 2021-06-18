using System;
using System.Collections.Generic;
using System.Text;

namespace MenuConsoleApp
{
    class ConsoleUI : IUI
    {
        public string GetInput()
        {
           return Console.ReadLine();
        }

        public ConsoleKeyInfo GetKeyInput()
        {
            return Console.ReadKey();
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public void Print(string message)
        {
            Console.Write(message);
        }
    }
}
