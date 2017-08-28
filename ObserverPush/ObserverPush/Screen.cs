using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPush
{
    public class Screen:IObserver
    {
        private bool isDisplayedType = false;//标记变量，标示是否已经打印过
        public void Update(BoiledEventArgs e)
        {
            if(!isDisplayedType)
            {
                Console.WriteLine("{0}-{1}:", e.Area, e.Type);
                Console.WriteLine();
                isDisplayedType = true;
            }
            if (e.Temperature < 100)
            {
                Console.WriteLine(string.Format("Alarm".PadRight(7) + ":水快烧开了，当前温度:{0}。", e.Temperature));
            }
            else
            {
                Console.WriteLine(string.Format("Alarm".PadRight(7) + ":水已经烧开了！！"));
            }
        }
    }
}
