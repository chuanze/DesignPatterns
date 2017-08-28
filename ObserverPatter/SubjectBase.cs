using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatter
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
        protected virtual void Notify()
        {
            foreach(IObserver observer in container)
            {
                observer.Update();
            }
        }
    }
}
