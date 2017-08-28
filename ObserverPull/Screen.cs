using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPull
{
    public class Screen:IObserver
    {
        private bool isDisplayedType = false;//标记变量，标示是否已经打印过
        public void Update(IObservable obj)
        {
            Heater heater = (Heater)obj;
            if(!isDisplayedType)
            {
                Console.WriteLine("{0}-{1}:", heater.Area, heater.Type);
                Console.WriteLine();
                isDisplayedType = true;
            }
            if (heater.Temperature < 100)
            {
                Console.WriteLine(string.Format("Alarm".PadRight(7) + ":水快烧开了，当前温度:{0}。", heater.Temperature));
            }
            else
            {
                Console.WriteLine(string.Format("Alarm".PadRight(7) + ":水已经烧开了！！"));
            }
        }
    }
}
