using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class inorder
    {
		//ba estefadeh az rah hal ketab ebarat mianvandi ra be pasvandi tabdil karde va bad az haman class postorder estefade mikonim
        public double Function_inorder(string s)
        {
			string postfix = InfixToPostfix(s);
			postorder p = new postorder();
			return p.Function_postorder(postfix);
        }

		public string InfixToPostfix(string s)
		{
			string result = "";
			Stack<char> operators = new Stack<char>();

			for (int i = 0; i < s.Length; i++)
			{
				char x = s[i];
				if (char.IsLetterOrDigit(x))
				{
					result += x;
				}
				else if (x == '(')
				{
					operators.Push(x);
				}
				else if (x == ')')
				{

					while (!IsEmpty(operators) && operators.Peek() != '(')
					{
						result += operators.Pop();
					}

					operators.Pop();
				}
				else
				{
					if (IsEmpty(operators) || OperatorPriority(x) > OperatorPriority(operators.Peek()))
					{
						operators.Push(x);
					}
					else if (OperatorPriority(x) < OperatorPriority(operators.Peek()))
					{
						while (!IsEmpty(operators) && OperatorPriority(x) < OperatorPriority(operators.Peek()))
						{
							result += operators.Pop();
						}
						operators.Push(x);
					}
					else
					{
						if (OperatorPriority(x) == 1 || OperatorPriority(x) == 2)
						{
							while (!IsEmpty(operators) && OperatorPriority(x) <= OperatorPriority(operators.Peek()))
							{
								result += operators.Pop();
							}
							operators.Push(x);
						}
						if (OperatorPriority(x) == 3)
						{
							operators.Push(x);
						}

					}
				}

			}


			while (!IsEmpty(operators))
			{
				result += operators.Pop();
			}

			return result;
		}
		public int OperatorPriority(char x)
		{
			if (x == '^')
			{
				return 3;

			}
			else if (x == '*' || x == '/')
			{
				return 2;
			}
			else if (x == '+' || x == '-')
			{
				return 1;
			}
			else
			{
				return -1;
			}
		}
		public bool IsEmpty(Stack<char> s)
		{
			if (s.Count == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
