using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0328
{
    public class MultiCounter
    {
        private int size;
        private int modulus;
        public int Size => size;
        private ChainedModularCounter[] cmc;
        public MultiCounter(int size, int modulus) 
        {
            this.size = size;
            this.modulus = modulus;
            cmc = new ChainedModularCounter[size];
            cmc[size - 1] = new ChainedModularCounter(modulus, null);
            for (int i = size - 2; i >= 0; i--)
                cmc[i] = new ChainedModularCounter(modulus, cmc[i + 1]);
        }
        public void Tick()
        {
            cmc[0].Tick();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = Size - 1; i >= 0; i--)
            {
                sb.Append(cmc[i].ToString());
            }
            return sb.ToString();
        }
    }
}
