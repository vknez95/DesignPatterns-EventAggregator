namespace SimpleEventAggregator
{
    public interface ISubscriber<T>
    {
        void OnEvent(T e);
    }
}
