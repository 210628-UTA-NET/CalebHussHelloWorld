using System;

namespace HouseFunction
{
    public class House
    {
        private string _color;
        private int _price;
        // this is a constructor for House
        public House()
        {
            Console.WriteLine("That constuctor of this class was used");
            _color = "red";
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        // java way
        public string getColor()
        {
            return _color;
        }

        public void setColor(string p_color)
        {
            _color = p_color;
        }
        public string Name { get; set; }







    }

}