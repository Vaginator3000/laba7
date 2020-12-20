using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    struct Autosale
    {
        Auto car;
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
            car = _car;
            count = _count;
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
