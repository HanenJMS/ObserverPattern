using ObserverPattern.OberverAbstract;
using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Magazine = new Subject();
            for (int i = 0; i < 10; i++)
            {
                string name = Console.ReadLine();
                Observer observer = new Observer(name);
                Magazine.AddObserver(observer);
            }
            
            Magazine.DoBusinessLogic();
            Magazine.DoBusinessLogic();
            Magazine.DoBusinessLogic();
            Console.ReadLine();
        }
    }
}
