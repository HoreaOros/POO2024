class Node<T>
{
    public T value;
    public Node<T> next;
}

public class StackLL<T>: IStack<T>
{
    Node<T>? head = null;
    int size = 0;
    public StackLL()
    {
    }

    public int Count => size;

    public T Peek()
    {
        if (Count > 0)
            return head.value;
        else
            throw new StackEmptyException("Peek(): stiva goala");
    }

    public T Pop()
    {
        if(Count > 0)
        {
            T ret = head.value;
            head = head.next;
            return ret;
        }
        else
            throw new StackEmptyException("Pop: stiva este goala");
    }

    public void Push(T value)
    {
        Node<T> node = new Node<T>();
        node.value = value;
        node.next = head;
        size++;
        head = node;
    }
}