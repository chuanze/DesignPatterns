using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPull
{
    public abstract class SubjectBase:IObservable
    {
        private List<IObserver> container = new List<IObserver>();
        public void Register(IObserver obj)
        {
            container.Add(obj);
        }
        public void UnRegister(IObserver obj)
        {
            container.Remove(obj);
        }
        protected virtual void Notify(IObservable obj)
        {
            foreach (IObserver observer in container)
            {
                observer.Update(obj);//调用Observer得Update()方法
            }
        }
    }
}
