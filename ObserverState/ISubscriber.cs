namespace ObserverPattern.ObserverState.Interface
{
    internal interface ISubscriber
    {
        string name { get; set; }
        void Update(object message);
        void SubscribeTo(ISubscription sub);
        void UnsubscribeTo(ISubscription sub);
    }
}
