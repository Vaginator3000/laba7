using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    struct Auto
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
            cost = 1;
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

        public void costInDollars_ref(ref int dcost)
        {
            dcost = cost * 73;
        }

        public void costInDollars_out(out int dcost)
        {
            dcost = cost * 73;
        }

        public static Auto operator +(Auto a, Auto b)
        {
            return new Auto { brand = a.brand + "-" + b.brand, color = a.color + "-" + b.color, Cost = a.Cost + b.Cost };
        }
        public static Auto operator ++(Auto a)
        {
            return new Auto { brand = a.brand, color = a.color, Cost = a.Cost + 1};
        }
    }
}
