public class StackLL<T>: IStack<T>
{
    private int size = 0;
    Node<T>? head = null;
    public StackLL()
    {
    }

    public int Count => size;

    public T Peek()
    {
        if (size > 0 && head != null)
            return head.data;
        else
            throw new StackEmptyException("Peek(): Stiva este goala");
    }

    public T Pop()
    {
        if (size > 0 && head != null)
        {
            T ret = head.data;
            head = head.next;
            return ret;
        }
        else
            throw new StackEmptyException("Pop(): Stiva este goala");
    }

    public void Push(T value)
    {
        Node<T> node = new Node<T>();
        node.data = value;
        node.next = head;
        head = node;
        size++; 
    }
}

public class Node<T>
{
    public T data;
    public Node<T>? next;
}