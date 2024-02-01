using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesement1
{
    internal class Calculator
    {
        public float num1;
        public float num2;
        public Calculator(float a, float b)
        {
            this.num1 = a;
            this.num2 = b;

        }
        public float sum()
        {
            return num1 + num2;
        }
        public float diff()
        {
            return num1 - num2;
        }
        public float product()
        {
            return num1 * num2;
        }
        public float div()
        {
            float res = 0.1F;
            res=num1 / num2;
            return res;
        }
    }
}
