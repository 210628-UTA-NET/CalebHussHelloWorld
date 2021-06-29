using System; // Importing system namespace
using HouseFunction;
using HelloWorld;
/*
use PascalCase for most of the naming
use camelCase for naming fields


*/

namespace HelloWorld
{
    class Program
    {
        private static string _first = "Hello";
        private static string _last = "World";


        /*
                =main method is the first methdo that will be ran when using the command dotnet run
                -static means, i dont have to instantiate the program class to use that method
                void method will not return anything

        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            test obj = new test();

            Console.WriteLine(obj.SomeMethod());
            Console.WriteLine(_first + _last);

            //house example
            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.setColor("blue");
            Console.WriteLine(objHouse.getColor());
            objHouse.Price = 8000;
            Console.WriteLine(objHouse.Price);
            Collection.CollectionMain();
        }
    }

    class test
    {
        public string SomeMethod()
        {
            //Console.WriteLine("Somemethod was called");
            return "Hello World Sommethod";
        }
    }


}
