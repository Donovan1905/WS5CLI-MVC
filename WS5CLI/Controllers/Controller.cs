using System;
using System.Collections.Generic;
using System.Text;
using WS5CLI.Views;

namespace WS5CLI.Controllers
{
    class Controller
    {
        private View View { get; set; }
        private bool IsRunning { get; set; }

        public Controller()
        {
            this.View = new View();
        }

        public void Start()
        {
            this.View.Start();
            this.IsRunning = true;
            while (this.IsRunning)
            {
                string input = this.GetInput();
                List<string> arguments = new List<string>(input.Split(' '));
                this.Parse(arguments);
            }
        }

        public void Stop()
        {
            this.View.Stop();
        }

        public string GetInput()
        {
            string input = this.View.GetInput();
            return input;
        }

        public void Parse(List<string> arguments)
        {
            string keyWord = arguments[0];
            arguments.RemoveAt(0);

            switch (keyWord)
            {
                case "open":
                    Console.WriteLine("open");
                    break;
                case "edit":
                    break;
                case "print":
                    Console.WriteLine("pas envie");
                    break;
                case "explore":
                    break;
                case "find":
                    break;
            }
        }

        
    }
}
