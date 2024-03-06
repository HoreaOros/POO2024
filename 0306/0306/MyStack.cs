using System.Diagnostics;

public class MyStack
{
    private int[] data;
    private int capacity = 16;
    private int size = 0;
    public MyStack()
    {
        Debug.Write($"Creating new stack with capacity {capacity}...");
        data = new int[capacity];
        Debug.WriteLine("success!");
    }
    public int Pop()
    {
        Console.WriteLine("Trying to Pop the stack...");
        if (size > 0)
        {
            size--;
            if (size == capacity / 4)
                resize(capacity / 2);
            Console.WriteLine("success!");
            return data[size];
        }
        else
            throw new StackEmptyException("A fost apelata functia Pop pe o stiva goala");
    }
    public void Push(int value)
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
        int[] newdata = new int[newCapacity];
        for (int i = 0; i < Count; i++)
        {
            newdata[i] = data[i];
        }
        capacity = newCapacity;
        data = newdata;
        Console.WriteLine("success");
    }

    public int Peek()
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