

namespace ObserverPattern.ObserverState.ClientManager
{
    internal class Client : Subscriber
    {
        public Client(string name)
        {
            this.name = name;
        }
    }
}
