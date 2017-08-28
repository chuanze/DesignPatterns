using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatter
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            Screen screen = new Screen();
            Alarm alarm = new Alarm();
            heater.Register(screen);
            heater.Register(alarm);
            heater.BoilWater();//烧水
            heater.UnRegister(alarm);//取消报警器得注册
            Console.WriteLine();
            heater.BoilWater();//再次烧水
            Console.ReadKey();
        }
    }
}
