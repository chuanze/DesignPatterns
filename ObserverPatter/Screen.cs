using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatter
{
    /// <summary>
    /// 显示器
    /// </summary>
    public class Screen:IObserver
    {
        public void Update()
        {
            Console.WriteLine("Screen".PadRight(7) + ":水快烧开了。");
        }
    }
}
