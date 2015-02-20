using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Division : TwoOperands
    {
        public Division(AbstractOperation l, AbstractOperation r) : base(l, r) { }
        public override float Eval()
        {
            float right_eval = right.Eval();
            if (right_eval == 0.0f)
                System.Console.WriteLine("Devide by zero");
            return (right_eval != 0.0f) ? (left.Eval() / right_eval) : float.MaxValue;
        }
    }
}
