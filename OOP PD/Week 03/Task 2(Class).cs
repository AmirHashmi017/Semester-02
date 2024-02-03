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
            res = num1 / num2;
            return res;
        }
        public float mod()
        {
            float res = num1 % num2;
            return res;
        }
        public float squareroot()
        {
            float res;
            res=(float)Math.Sqrt(num1);
            return res;
        }
        public float exponent()
        {
            float res;
            res = (float)Math.Exp(num1);
            return res;
        }
        public float log()
        {
            float res;
            res = (float)Math.Log(num1);
            return res;
        }
        public float sin()
        {
            float res;
            res = (float)Math.Sin(num1);
            return res;
        }
        public float cos()
        {
            float res;
            res = (float)Math.Cos(num1);
            return res;
        }
        public float tan()
        {
            float res;
            res = (float)Math.Tan(num1);
            return res;
        }
    }
}