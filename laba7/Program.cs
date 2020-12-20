using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] car = new Auto[3];

            for (int i = 0; i < car.Length; i++)
            {
                car[i] = new Auto();
                car[i].init("car" + i.ToString(), "color" + i.ToString(), i * 10000 + i);
            }

           /* car.init("Ford", "black", 300000);
            car.display();
            car.read();
            car.display();*/

            Autosale asale = new Autosale();
            asale.init(car[1], 3);
            asale.display();
            asale.read();
            asale.display();
        }
    }
}
