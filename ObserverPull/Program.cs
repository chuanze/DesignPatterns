using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPull
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            Screen screen = new Screen();
            heater.Register(screen);//注册显示器
            heater.BoilWater();//烧水
            Console.ReadKey();
        }
    }
}
