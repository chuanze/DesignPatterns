using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPull
{
    public interface IObserver
    {
        //推模式的实现方式，接收一个BoiledEventArgs
        void Update(IObservable sender);
    }
}
