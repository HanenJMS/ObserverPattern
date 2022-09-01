namespace ObserverPattern.ObserverState.Interface
{
    internal interface ISubscription
    {
        string name { get; set; }
        void NotifySubscribers(object message);
        bool AddSubscriber(ISubscriber subscriber);
        bool RemoveSubscriber(ISubscriber subscriber);
    }
}
