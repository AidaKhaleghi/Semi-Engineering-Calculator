using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class preorder
    {
        public double Function_preorder(string s)
        {
            //rah hal mesl jozveh
            Stack<string> my_stack = new Stack<string>();
            string s1, s2;
            double r;
            for (int i = s.Length-1 ; i > -1; i--)
            {
                if (s[i] == '+')
                {
                    //avalin elemani ke az stack kharej mishavad haman avalin operand ast
                    s1 = my_stack.Pop();
                    s2 = my_stack.Pop();
                    r = Convert.ToDouble(s1) + Convert.ToDouble(s2);
                    my_stack.Push(Convert.ToString(r));
                }
                else if (s[i] == '-')
                {
                    s1 = my_stack.Pop();
                    s2 = my_stack.Pop();
                    r = Convert.ToDouble(s1) - Convert.ToDouble(s2);
                    my_stack.Push(Convert.ToString(r));
                }
                else if (s[i] == '*')
                {
                    s1 = my_stack.Pop();
                    s2 = my_stack.Pop();
                    r = Convert.ToDouble(s1) * Convert.ToDouble(s2);
                    my_stack.Push(Convert.ToString(r));
                }
                else if (s[i] == '/')
                {
                    s1 = my_stack.Pop();
                    s2 = my_stack.Pop();
                    r = Convert.ToDouble(s1) / Convert.ToDouble(s2);
                    my_stack.Push(Convert.ToString(r));
                }
                else if (s[i] == '^')
                {
                    s1 = my_stack.Pop();
                    s2 = my_stack.Pop();
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
