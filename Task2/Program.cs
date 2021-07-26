using System;

namespace Task2
{
    class Program
    {
        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            Logger = new Logger();
            var w1 = new Calculator(Logger);

            try
            {
                Console.WriteLine("Введите первое число");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double number2 = Convert.ToDouble(Console.ReadLine());

                double rezult = w1.Sum(number1, number2);
                Console.WriteLine($"Результат = {rezult:F2}");
            }
            catch (Exception ex)
            {
                if (ex is OverflowException)
                    w1.Errow("Ошибка: переполнение");
                else
                     if (ex is FormatException)
                    w1.Errow("Ошибка: не формат");
                else
                    w1.Errow("Ошибка:" + ex.Message);

            }
        }

    }
}
