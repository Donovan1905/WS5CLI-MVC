using System;
using System.Collections.Generic;
using System.Text;
using WS5CLI.Views;
using WS5CLI.Models;
using System.Linq;

namespace WS5CLI.Controllers
{
    class Controller
    {
        private View View { get; set; }

        private Open open { get; set; }

        private bool IsRunning { get; set; }

        public Controller()
        {
            this.View = new View();
            this.open = new Open();
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
            this.IsRunning = false;
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
                    if(arguments.Count() == 1)
                    {
                        this.open.CreateProcess(arguments[0]);
                    }
                    else if (arguments.Count() == 2)
                    {
                        this.open.CreateProcess(arguments[0], arguments[1]);
                    }
                    
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
                case "exit":
                    this.Stop();
                    break;
            }
        }

        public void Open(List<string> arguments)
        {

        }

        public void Edit(List<string> arguments)
        {

        }

        public void Print(List<string> arguments)
        {

        }

        public void Explore(List<string> arguments)
        {

        }

        public void Find(List<string> arguments)
        {

        }

    }
}
