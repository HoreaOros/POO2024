using System.Text.RegularExpressions;

internal class MaxHeap
{
    #region Fields
    private int capacity;
    private int heapSize;
    private int[] A;
    #endregion

    #region Constructors
    public MaxHeap(int capacity)
    {
        this.capacity = capacity;
        A = new int[capacity + 1];
        heapSize = 0;
    }
    #endregion

    #region Properties
    /// <summary>
    /// Maximum number of elements that the MaxHeap may contain
    /// </summary>
    public int Capacity
    {
        get
        {
            return capacity;
        }
    }
  
    /// <summary>
    /// Number of elements contained by the MaxHeap
    /// </summary>
    public int HeapSize
    {
        get { return heapSize; }
    }

    #endregion

    #region Methods
    private int Parent(int i) => i / 2;
    private int Left(int i) => 2 * i;
    private int Right(int i) => 2 * i + 1;
    private void MaxHeapify(int i)
    {
        int l, r, largest;
        l = Left(i);
        r = Right(i);
        if (l <= HeapSize && A[i] < A[l])
            largest = l;
        else
            largest = i;

        if(r <= HeapSize && A[largest] < A[r])
            largest = r;

        if(largest != i)
        {
            (A[i], A[largest]) = (A[largest], A[i]);
            MaxHeapify(largest);
        }
    }
    #endregion


}