using System;
using WS5CLI.Controllers;

namespace WS5CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Start();
        }
    }
}
