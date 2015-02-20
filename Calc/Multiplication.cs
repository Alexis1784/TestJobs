using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Multiplication : TwoOperands
    {
        public Multiplication(AbstractOperation l, AbstractOperation r) : base(l, r) { }
        public override float Eval() { return left.Eval() * right.Eval(); }
    }
}
