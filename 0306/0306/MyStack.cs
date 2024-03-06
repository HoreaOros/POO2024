using System.Diagnostics;

public class MyStack<T>
{
    private T[] data;
    private int capacity = 16;
    private int size = 0;
    /// <summary>
    /// Constructor implicit
    /// </summary>
    public MyStack()
    {
        Console.Write($"Creating new stack with capacity {capacity}...");
        data = new T[capacity];
        Console.WriteLine("success!");
    }
    /// <summary>
    /// Intoarce si elimina elementul din varful stivei
    /// </summary>
    /// <returns></returns>
    /// <exception cref="StackEmptyException"></exception>
    public T Pop()
    {
        Console.WriteLine("Trying to Pop the stack...");
        if (size > 0)
        {
            T ret = data[size - 1];
            if (size == capacity / 4)
                resize(capacity / 2);
            Console.WriteLine("success!");
            size--;
            return ret;
        }
        else
            throw new StackEmptyException("A fost apelata functia Pop pe o stiva goala");
    }
    /// <summary>
    /// Adauga o noua valoare in stiva
    /// </summary>
    /// <param name="value">Valoarea care se adauga</param>
    public void Push(T value)
    {
        Console.WriteLine($"Trying to push {value} into the stack...");
        if (Count == capacity)
        {
            resize(2 * capacity);
        }
        data[size++] = value;
        Console.WriteLine("success!");
    }

    private void resize(int newCapacity)
    {
        Console.Write($"Resizing stack: old capacity = {capacity}, new capacity = {newCapacity}...");
        T[] newdata = new T[newCapacity];
        for (int i = 0; i < Count; i++)
        {
            newdata[i] = data[i];
        }
        capacity = newCapacity;
        data = newdata;
        Console.WriteLine("success");
    }

    public T Peek()
    {
        Console.Write("Try to peek into the stack...");
        if (size > 0)
        {
            Console.WriteLine("success");
            return data[size - 1];
        }
        else
            throw new StackEmptyException("A fost apelata functia Peek pe o stiva goala");
    }
    //public int Count 
    //{ 
    //    get
    //    {
    //        return size;
    //    }
    //}
    public int Count => size;
}