namespace _0328
{
    public class Counter
    {
        protected int _count;
        public Counter(int count)
        { 
            _count = count; 
        }
        public Counter():this(0) { }
        public int Count 
        { 
            get 
            { 
                return _count; 
            } 
        }
        virtual public void Tick()
        {
            _count++;
        }
        public override string ToString()
        {
            return Count.ToString();
        }
    }
}