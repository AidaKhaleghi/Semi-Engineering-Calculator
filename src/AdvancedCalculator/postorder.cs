using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class postorder
    {
        public double Function_postorder(string s)
        {
            //rah hal mesl jozveh
            Stack<string> my_stack = new Stack<string>();
            string s1, s2;
            double r;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '+')
                {
                    //avalin elemani ke az stack kharej mishavad, dovomin operand ast
                    s2 = my_stack.Pop();
                    s1 = my_stack.Pop();
                    r = Convert.ToDouble(s1) + Convert.ToDouble(s2);
                    my_stack.Push(Convert.ToString(r));
                }
                else if (s[i] == '-')
                {
                    s2 = my_stack.Pop();
                    s1 = my_stack.Pop();
                    r = Convert.ToDouble(s1) - Convert.ToDouble(s2);
                    my_stack.Push(Convert.ToString(r));
                }
                else if (s[i] == '*')
                {
                    s2 = my_stack.Pop();
                    s1 = my_stack.Pop();
                    r = Convert.ToDouble(s1) * Convert.ToDouble(s2);
                    my_stack.Push(Convert.ToString(r));
                }
                else if (s[i] == '/')
                {
                    s2 = my_stack.Pop();
                    s1 = my_stack.Pop();
                    r = Convert.ToDouble(s1) / Convert.ToDouble(s2);
                    my_stack.Push(Convert.ToString(r));
                }
                else if (s[i] == '^')
                {
                    s2 = my_stack.Pop();
                    s1 = my_stack.Pop();
                    r = Math.Pow(Convert.ToDouble(s1), Convert.ToDouble(s2));
                    my_stack.Push(Convert.ToString(r));
                }
                else
                {
                    my_stack.Push(Convert.ToString(s[i]));
                }
            }
            return Convert.ToDouble(my_stack.Pop());
        }
    }
}
