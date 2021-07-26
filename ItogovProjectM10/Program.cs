using System;

namespace ItogovProjectM10
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator bc = new Calculator();

            try
            {
                Console.WriteLine("Введите первое число");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double number2 = Convert.ToDouble(Console.ReadLine());

                double rezult = bc.Sum(number1, number2);
                Console.WriteLine($"Результат суммы двух чисел   {rezult:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

        }
    }
}
