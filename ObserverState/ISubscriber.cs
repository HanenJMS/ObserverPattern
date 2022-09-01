namespace ObserverPattern.ObserverState.Interface
{
    internal interface ISubscriber
    {
        string name { get; set; }
        void Update(object message);
        void SubscribeTo(IPublisher sub);
        void UnsubscribeTo(IPublisher sub);
    }
}
