using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class Auto
    {
        String brand;
        String color;
        int cost;

        public int Cost
        {
            set { cost = value; }
            get { return cost; }
        }

        public void init()
        {
            brand = "";
            color = "";
            cost = 0;
        }
        public void init(String _brand, String color, int _cost)
        {
            brand = _brand;
            this.color = color;
            cost = _cost;
        }
        public void display()
        {
            Console.WriteLine($"{brand}, {color} - {cost}p");
        }
        public void read()
        {
            Console.WriteLine("Марка: ");
            brand = Console.ReadLine();
            Console.WriteLine("Цвет: ");
            color = Console.ReadLine();
            Console.WriteLine("Стоимость: ");
            cost = Convert.ToInt32(Console.ReadLine());
        }
    }
}
