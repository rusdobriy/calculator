using System;

namespace calculator
{
    internal class Program

    {
        static double InputNumber()
        {
            double firstNumber = 0;
            while (true)
            {
                try
                {
                    firstNumber = double.Parse(Console.ReadLine());
                    return firstNumber;
                }
                catch
                {
                    Console.WriteLine("пиши числа!!");
                }
            }
        }
        static void Main()
        {   
            double firstNumber = 0;
            string action = "";
            double secondNumber = 0;

            while (true)
            {
                Console.WriteLine("напишите первое число");
                firstNumber = InputNumber();

                Console.WriteLine("напишите математическое действие");
                action = Console.ReadLine();

                if (action == "#")
                {
                    Console.WriteLine("ответ - " + Math.Sqrt(firstNumber));
                    continue;
                }
                if (action == "exit")
                {
                    Console.WriteLine("Спасибо за выбор нашей авиакомпании, ждем ваших инвестиций в наше светлое будущее");
                    return;
                }

                Console.WriteLine("напишите второе число");
                secondNumber = InputNumber();

                Actions(firstNumber, action, secondNumber);
            }
        }
        static void Actions(double firstNumber, string action, double secondNumber)
        {
            if (action == "/")
            {
                if (secondNumber != 0)
                {
                    Console.WriteLine("ответ - " + (firstNumber / secondNumber));
                }
                else
                {
                    Console.WriteLine("Не дели на ноль");
                }
            }
            if (action == "+")
            {
                Console.WriteLine("\nответ - " + (firstNumber + secondNumber));
            }

            if (action == "-")
            {
                Console.WriteLine("ответ - " + (firstNumber - secondNumber));
            }
            if (action == "*")
            {
                Console.WriteLine("ответ - " + (firstNumber * secondNumber));
            }
            if (action == "@")
            {
                Console.WriteLine("ответ - " + Math.Pow(firstNumber, secondNumber));
            }
        }
    }
}
