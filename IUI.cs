using System;
using System.Collections.Generic;
using System.Text;

namespace MenuConsoleApp
{
    public interface IUI
    {
        string GetInput();
        ConsoleKeyInfo GetKeyInput();
        void Write(string message);
        void Print(string message);
    }
}
