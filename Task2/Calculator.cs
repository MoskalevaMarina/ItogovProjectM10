using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
   public class Calculator : ICalculator
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public double Sum(double number1, double number2)
        {
            Logger.Event("Нахождение суммы двух чисел");
            return number1 + number2;
        }
      
        public void Errow(string message)
        {
            Logger.Errow(message);
        }
    }
}
