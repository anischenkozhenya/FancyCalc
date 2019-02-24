using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            double sum;
            try
            {
                checked
                {
                    sum = a + b;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            return sum;
        }


        public double Subtract(int a, int b)
        {
            double sbtract;
            try
            {
                checked
                {
                    sbtract = a - b;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            return sbtract;
        }


        public double Multiply(int a, int b)
        {
            double multply;
            try
            {
                checked
                {
                    multply = a * b;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            return multply;
        }

        public double Culculate(string expression)
        {
            if (expression==null)
            {
                throw new ArgumentNullException();
            }
            char[] exp = expression.ToCharArray();
            double result = 0;
            char simbol = ' ';
            char[] firstnum = new char[exp.Length], secondnum = new char[exp.Length];
            for (int i = 0; i < firstnum.Length; i++)
            {
                firstnum[i] = ' ';
            }
            for (int i = 0; i < secondnum.Length; i++)
            {
                secondnum[i] = ' ';
            }
            bool ch = true;
            for (int i = 0; i < exp.Length; i++)
            {
                if (char.IsNumber(exp[i]) && ch == true)
                {
                    firstnum[i] = exp[i];
                }
                else
                {
                    ch = false;
                }
                if (exp[i] == '*' || exp[i] == '+' || exp[i] == '-')
                {
                    simbol = exp[i];
                }
                if (simbol != ' ' && ch == false && char.IsNumber(exp[i]))
                {
                    secondnum[i] = exp[i];
                }
            }
            if (simbol == '+')
            {

                result = Add(int.Parse(new string(firstnum)), int.Parse(new string(secondnum)));
            }
            if (simbol == '*')
            {
                result = Multiply(int.Parse(new string(firstnum)), int.Parse(new string(secondnum)));
            }
            if (simbol == '-')
            {
                result = Subtract(int.Parse(new string(firstnum)), int.Parse(new string(secondnum)));
            }
            return result;
        }
    }
}
