using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.OberverAbstract
{
    internal class Observer : IObserver
    {
        string name;
        public Observer(string name)
        {
            this.name = name;
        }

        public void Update()
        {
            Console.WriteLine($"{name} has been notified.");
        }
    }
}
