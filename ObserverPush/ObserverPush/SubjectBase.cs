using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPush
{
    public abstract class SubjectBase
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
        protected virtual void Notify(BoiledEventArgs e)
        {
            foreach (IObserver observer in container)
            {
                observer.Update(e);//调用Observer得Update()方法
            }
        }
    }
}
