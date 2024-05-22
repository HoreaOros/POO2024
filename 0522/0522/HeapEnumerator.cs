using System.Collections;

internal class HeapEnumerator : IEnumerator<int>
{
    private int _index = 0;
    private MaxHeap maxHeap;

    public HeapEnumerator(MaxHeap maxHeap)
    {
        this.maxHeap = maxHeap;
    }

    public int Current => maxHeap[_index];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        if (_index >= maxHeap.HeapSize)
            return false;

        _index++;
        return true;
    }

    public void Reset()
    {
        _index = 0;
    }
}