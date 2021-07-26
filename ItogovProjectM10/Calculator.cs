using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM10
{
    class Calculator : ICalculator
    {
        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
