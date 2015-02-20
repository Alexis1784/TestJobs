using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    // Одинокий минус
    public class Negation : OneOperand
    {
        public Negation(AbstractOperation n) : base(n) { }
        public override float Eval() { return -one.Eval(); }
    }
}
