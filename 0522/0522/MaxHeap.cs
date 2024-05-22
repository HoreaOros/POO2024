using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

internal class MaxHeap: IEnumerable<int>
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

    public MaxHeap(int[] vector)
    {
        this.A = new int[vector.Length + 1];
        for(int i = 0; i < vector.Length; i++)
        {
            A[i + 1] = vector[i];
        }
        this.HeapSize = vector.Length;
        BuildMaxHeap();
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
        private set { heapSize = value; }
    }
    public int this[int index]
    {
        get
        {
            return A[index];
        }
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
        if (l <= HeapSize && A[i].CompareTo(A[l]) < 0)
            largest = l;
        else
            largest = i;

        if(r <= HeapSize && A[largest].CompareTo(A[r]) < 0)
            largest = r;

        if(largest != i)
        {
            (A[i], A[largest]) = (A[largest], A[i]);
            MaxHeapify(largest);
        }
    }
    private void BuildMaxHeap()
    {
        for (int i = HeapSize / 2; i >= 1; i--)
            MaxHeapify(i);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= HeapSize; i++)
        {
            sb.Append(A[i]);
            sb.Append(" ");
        }
        return sb.ToString();
    }

    public IEnumerator<int> GetEnumerator()
    {
        //return new HeapEnumerator(this); 
        return ((IEnumerable<int>)A).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    #endregion


}

