using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public abstract class OneOperand : AbstractOperation
    {
        public OneOperand(AbstractOperation op) { one = op; }

        protected AbstractOperation one;
    }
}
