using System;
using System.Collections.Generic;
using System.Text;

namespace WS5CLI.Views
{
    class View
    {
        public View()
        {

        }

        public void Start()
        {
            Console.WriteLine("Hellop, type 'help' to see the commands");
        }

        public void Stop()
        {
            Console.WriteLine("Stop...");
        }

        public string GetInput()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WS5> ");
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            return input;
        }
    }
}
