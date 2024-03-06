public class MyStack<T> : IStack<T>
{
    private int size = 0;
    private T[] data;
    private int capacity = 16;
    public int Count => size;
    public MyStack()
    {
        data = new T[capacity];
    }

    public void Push(T value)
    {
        Console.WriteLine($"Trying to push {value} onto the stack...");
        if (size == capacity)
        {
            resize(2 * capacity);
        }

        data[size++] = value;
        Console.WriteLine("Success - push");
    }

    public T Peek()
    {
        if (size > 0)
            return data[size - 1];
        else
            throw new StackEmptyException("Peek(): Stiva este goala");
    }

    private void resize(int newcapacity)
    {
        Console.WriteLine($"Trying to resize stack. Old value {capacity}, New value {newcapacity}");
        T[] newdata = new T[newcapacity];
        for (int i = 0; i < size; i++)
            newdata[i] = data[i];
        capacity = newcapacity;
        data = newdata;
        Console.WriteLine("Success - resize!");
    }

    public T Pop()
    {
        Console.WriteLine("Trying to pop the stack");
        if (size > 0)
        {
            T ret = data[size - 1];
            size--;
            if (size == capacity / 4)
                resize(capacity / 2);
            Console.WriteLine("Success - pop");
            return ret;
        }
        else
        {
            Console.WriteLine("Exception occured. Stack empty!");
            throw new StackEmptyException("Pop(): stiva este goala");
        }
    }
}