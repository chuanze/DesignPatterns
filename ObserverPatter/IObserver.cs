using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatter
{
    public interface IObserver
    {
        void Update();//事件触发时由Subject调用，更新自身状态
    }
}
