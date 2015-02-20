using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public abstract class TwoOperands : AbstractOperation
    {
        public TwoOperands(AbstractOperation l, AbstractOperation r) { left = l; right = r; }

        protected AbstractOperation left, right;
    }
}
