using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0328
{
    public class ChainedModularCounter: ModularCounter
    {
        private ChainedModularCounter next;
        public ChainedModularCounter(int modulus, ChainedModularCounter next): base(modulus) 
        {
            this.next = next;
        }
        public override void Tick()
        {
            base.Tick();
            if (Count == 0)
            {
                if(next != null)
                    next.Tick();
            }
        }
    }
}
