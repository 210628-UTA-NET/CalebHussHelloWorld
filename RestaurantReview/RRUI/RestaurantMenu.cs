using System;

namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Restaurant Menu");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Give list of resaurants");
            Console.WriteLine("[0] Go back");
        }

        public string YourChoice()
        {
            throw new NotImplementedException();
        }
    }
}