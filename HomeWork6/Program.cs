using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string InputString(string str)
                {
                    Console.WriteLine(str);
                    return Console.ReadLine();
                }

                double InputDouble(string str)
                {
                    Console.Write(str);
                    return Convert.ToDouble(Console.ReadLine());
                }

                int Score(string number, int count)
                {
                    if (Convert.ToInt32(number) > 0)
                    {
                        count++;
                    }
                    return count;
                }

                Console.WriteLine("Введите номер задания");
                Console.WriteLine("1 - Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
                Console.WriteLine("2 - Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями " +
                    "y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
                string task = Console.ReadLine();
                Console.Clear();

                switch (task)
                {
                    case "1":
                        string line = InputString("Введите числа через запятую");
                        string number = "";
                        int quantity = 0;

                        for (int index = 0; index < line.Length; index++)
                        {
                            if (line[index] == ',')
                            {
                                quantity = Score(number, quantity);
                                number = "";
                            }
                            else
                            {
                                number += line[index];
                            }
                            if (index == line.Length - 1)
                            {
                                quantity = Score(number, quantity);
                            }
                        }

                        Console.WriteLine("Колличество чисел больше 0 = " + quantity);
                        break;
                    case "2":
                        double x, y;
                        double firstNumber = InputDouble("b1 = ");
                        double firstMultiplier = InputDouble("k1 = ");
                        double secondNumber = InputDouble("b2 = ");
                        double secondMultiplier = InputDouble("k2 = ");

                        if (firstMultiplier != secondMultiplier)
                        {
                            x = Math.Round(-((secondNumber - firstNumber) / (secondMultiplier - firstMultiplier)), 2);
                            y = Math.Round(secondMultiplier * x + secondNumber, 2);
                            Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
                        }
                        else
                        {
                            Console.WriteLine("Линии параллельны и не имеют точку пересечения");
                        }
                        break;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Что-то пошло не так :(");
            }

            Console.ReadKey();
        }
    }
}
