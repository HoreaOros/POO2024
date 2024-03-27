using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0328
{
    public class ModularCounter: Counter
    {
        private int _modulus;
        public ModularCounter(int modulus): this(modulus, 0)
        {
        }
        public ModularCounter(int modulus, int count): base(count) 
        {
            _modulus = modulus;
        }
        public override void Tick()
        {
            base.Tick();
            _count %= _modulus;
        }
    }
}
