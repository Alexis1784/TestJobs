using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc;

namespace Main
{
    public class ToExpression
    {
        public ToExpression(string s) { source = s; }

        public float Calc()
        {
            pos = 0;
            AbstractOperation root = Parse0();
            return (root != null) ? root.Eval() : 0.0f;
        }

        // Низкий приоритет: сложение, вычитание
        private AbstractOperation Parse0()
        {
            AbstractOperation result = Parse1();

            for (; ; )
            {
                if (Match('+')) result = new Addition(result, Parse1());
                else if (Match('-')) result = new Subtraction(result, Parse1());
                else return result;
            }
        }

        // Средний приоритет: умножение, деление
        private AbstractOperation Parse1()
        {
            AbstractOperation result = Parse2();
            for (; ; )
            {
                if (Match('*')) result = new Multiplication(result, Parse2());
                else if (Match('/')) result = new Division(result, Parse2());
                else return result;
            }
        }

        // Высокий приоритет: одинокий минус, скобки, число
        private AbstractOperation Parse2()
        {
            AbstractOperation result = null;

            if (Match('-'))
            {
                result = new Negation(Parse0());
            }
            else if (Match('('))
            {
                result = Parse0();
                if (!Match(')'))
                    System.Console.WriteLine("Missing ')'");
            }
            else
            {
                // распарсим число
                float val = 0.0f;
                int start = pos;
                while (pos < source.Length && (char.IsDigit(source[pos]) || source[pos] == '.' || source[pos] == 'e')) ++pos;

                try { val = float.Parse(source.Substring(start, pos - start)); }
                catch { System.Console.WriteLine("Can't parse '" + source.Substring(start) + "'"); }
                result = new Number(val);

            }
            return result;
        }

        // Поищем символ в строке
        private bool Match(char ch)
        {
            if (pos >= source.Length) return false;
            while (source[pos] == ' ') ++pos;             // пропустим пробелы

            if (source[pos] == ch) { ++pos; return true; } // нашли что искали?
            else return false;
        }

        private string source;     // исходная строчка
        private int pos;        // текущая позиция
    }
}
