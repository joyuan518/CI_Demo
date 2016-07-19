using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_Demo.Function
{
    public class Calculator
    {
        public float Add(float operatorA, float operatorB)
        {
            return operatorA + operatorB;
        }

        public float Sub(float operatorA, float operatorB)
        {
            return operatorA - operatorB;
        }

        public float Multiply(float operatorA, float operatorB)
        {
            return operatorA * operatorB;
        }

        public float Divide(float operatorA, float operatorB)
        {
            return operatorA / operatorB;
        }
    }
}
