using System;
using RRModels;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu restMenu = new MainMenu();
            bool repeat = true;
            string currentMenu = "Mainmenu";
            while (repeat)
            {
                Console.Clear();
                restMenu.Menu();
                currentMenu = restMenu.YourChoice();
                switch (currentMenu)
                {
                    case "Exit":
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Cannot Process entry");
                        break;
                }
            }
        }
    }
}
