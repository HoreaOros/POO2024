using Util;

namespace A
{
    internal class Date : IComparable<Date>
    {
        #region Fields
        private int zi;
        private int luna;
        private int an;
        private bool anBisect = false;
        #endregion

        #region Constructors
        public Date(string str)
        {
            string[] tokens = str.Split(new char[] { '/', '-' });
            if (tokens.Length != 3)
                throw new ArgumentException("Sirul de caractere nu este o data valida");

            try
            {
                zi = int.Parse(tokens[0]);
                luna = int.Parse(tokens[1]);
                an = int.Parse(tokens[2]);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e) 
            {
                Console.WriteLine(e.Message);
            }
            ValiDate(zi, luna, an);
        }
        public Date(int zi, int luna, int an)
        {
            ValiDate(zi, luna, an);
            this.zi = zi;
            this.luna = luna;
            this.an = an;
        }
        #endregion

        #region Methods
        private void ValiDate(int zi, int luna, int an)
        {
            if (an < 0 || an > 9999)
                throw new ArgumentException("Invalid argument");


            if(luna < 1 || luna > 12)
                throw new ArgumentException("Invalid argument");
            var dict = new Dictionary<int, int>()
            {
                [1] = 31,
                [2] = 28,
                [3] = 31,
                [4] = 30,
                [5] = 31,
                [6] = 30,
                [7] = 31,
                [8] = 31,
                [9] = 30,
                [10] = 31,
                [11] = 30,
                [12] = 31
            };

            anBisect = (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);
            if (anBisect)
                dict[2]++;

            if(zi < 1 || zi > dict[luna])
                throw new ArgumentException("Invalid argument");
        }
        public override string ToString()
        {
            return $"{zi} {luna.ToMonthName()} {an}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == this)
                return true;

            if (obj == null)
                return false;

            if (obj.GetType() != this.GetType())
                return false;

            Date that = (Date)obj;
            return (this.an == that.an && this.luna == that.luna && this.zi == that.zi);
        }
        public override int GetHashCode()
        {
            //int hash = 17;
            //hash = 31 * hash + luna;
            //hash = 31 * hash + zi;
            //hash = 31 * hash + an;
            //return hash;

            return HashCode.Combine(an, luna, zi);
        }

        public int CompareTo(Date? other)
        {
            if (other == null) 
                return 1;
            if(this.an < other.an) return -1;
            if(this.an > other.an) return 1;
            if (this.luna < other.luna) return -1;
            if (this.luna > other.luna) return 1;
            if (this.zi < other.zi) return -1;
            if (this.zi > other.zi) return 1;
            return 0;

        }
        #endregion

        #region Properties
        public int Zi { get { return zi; } }
        public int Luna { get { return luna; } }
        public int An { get { return an; } }
        #endregion
    }
}