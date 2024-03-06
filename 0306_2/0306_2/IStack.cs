public interface IStack<T>
{
    int Count { get; }

    T Peek();
    T Pop();
    void Push(T value);
}