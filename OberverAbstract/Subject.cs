using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern.OberverAbstract
{
    internal class Subject : ISubject
    {
        int state;
        List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            Console.WriteLine("Subject added an observer");
            observers.Add(observer);
        }

        public void Notify(int state)
        {
            Console.WriteLine("Notifying all observers");
            observers[state].Update();
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Subject removed an observer");
            observers.Remove(observer);
        }
        public void DoBusinessLogic()
        {
            Random random = new Random(DateTime.Now.Second);
            state = random.Next(observers.Count);
            Notify(state);
            Thread.Sleep(150);
        }
    }
}
