using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPull
{
    public interface IObservable
    {
        void Register(IObserver obj);//注册Observer
        void UnRegister(IObserver obj);//取消注册
    }
}
