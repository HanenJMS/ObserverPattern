using ObserverPattern.OberverAbstract;
using ObserverPattern.ObserverState;
using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestingAbstract();
            Client thisIsMe = new Client("Jung");
            Client SomeElse = new Client("Tommy");
            Subscription techGenius = new Subscription("Tech Genius");
            thisIsMe.SubscribeTo(techGenius);
            thisIsMe.SubscribeTo(techGenius);
            SomeElse.SubscribeTo(techGenius);
            techGenius.ChangeMessage("Attention: This is an update. That is all.");
            Console.ReadLine();
        }

        private static void TestingAbstract()
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
        }
    }
}
