﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class Autosale
    {
        Auto car = new Auto();
        int count;
        public int Count
        {
            set { count = value; }
            get { return count; }
        }
        public void init()
        {
            car.init();
            count = 0;
        }
        public void init(Auto _car, int _count)
        {
            count = _count;
            car = _car;
        }
        public void display()
        {
            car.display();
            Console.WriteLine($"Количество: {count}");
        }
        public void read()
        {
            car.read();
            Console.WriteLine("Количество: ");
            count = Convert.ToInt32(Console.ReadLine());
        }

    }
}
