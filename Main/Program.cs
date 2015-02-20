using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc;


namespace Main
{
    public class Program
    {
        

        public static void Main()
        {
            System.Console.WriteLine("Enter expression:");
            string buf = System.Console.ReadLine();

            ToExpression expr = new ToExpression(buf);
            System.Console.WriteLine(expr.Calc().ToString("g"));
            Console.ReadLine();
        }
    }
}
