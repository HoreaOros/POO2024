namespace Rectangle
{
    public class EndComparer : IComparer<Interval>
    {
        public int Compare(Interval? x, Interval? y)
        {
            return x!.End - y!.End;
        }
    }
    public class Interval: IComparable<Interval>, IEquatable<Interval>
    {
        public Interval(int a, int b)
        {
            if (a > b)
                (a, b) = (b, a);
            Start = a;
            End = b;
        }
        public int Length => Math.Abs(End - Start);

        public int Start { get; }
        public int End { get; }

        public int CompareTo(Interval? other)
        {
            if (other == null)
                return 1;
            return this.Length - other.Length;
        }

        public bool Equals(Interval? other)
        {
            if(other == null)
                return false;
            return this.Start == other.Start && this.End == other.End;
        }

        public bool IntersectsWith(Interval other)
        {
            return !(this.End < other.Start || other.End < this.Start);
        }
    }
}