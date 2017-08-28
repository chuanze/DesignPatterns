using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatter
{
    public class Alarm:IObserver
    {
        public void Update()
        {
            Console.WriteLine("Alarm".PadRight(7) + ":嘟嘟嘟,水温快烧开了.");
        }
    }
}
