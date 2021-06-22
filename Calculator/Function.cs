using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Function
    {
        private double a = 0;

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }

        public double Multiplication(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            return a / b;
        }

        public double Sum(double b)
        {
            return a + b;
        }

        public double Subtraction(double b) 
        {
            return a - b;
        }

        public double Sin(double b)
        {
            return b = Math.Sin(a);
        }




    }
}
