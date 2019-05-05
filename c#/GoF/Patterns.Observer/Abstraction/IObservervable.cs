namespace Patterns.Observer.Abstraction
{
    public interface IObservervable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
