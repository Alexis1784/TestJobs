using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    // Просто число
    public class Number : AbstractOperation
    {
        public Number(float f) { value = f; }
        public override float Eval() { return value; }

        private float value;
    }
}
