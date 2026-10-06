using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorVer06
{
    internal class Math
    {
        public double Execute(int choice)
        {
            double result = 0;
            if (choice == 0)
            {
                Console.Write("Введите число");
                double num = double.Parse(Console.ReadLine());
                Console.Write("Введите процент(%)");
                double percent = double.Parse(Console.ReadLine());
                result = num * percent / 100;
            }
            if (choice == 1)
            {
                Console.Write("Введите первое число");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());
                result = num1 * num2;
            }
            if (choice == 2)
            {
                Console.Write("Введите делимое: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите делитель: ");
                double num2 = double.Parse(Console.ReadLine());

                if (num2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    return 0;
                }
                result = num1 / num2;
            }
            if (choice == 3)
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());
                result = num1 - num2;
            }
            if (choice == 4)
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());
                result = num1 + num2;
            }
            if (choice == 5)
            {
                Console.Write("Введите размер массива");
                int countindex = int.Parse(Console.ReadLine());
                int[] array = new int[countindex];
                int sum = 0;
                for (int i = 0; i < countindex; i++)
                {
                    Console.Write($"Элемент [{i}]: ");
                    array[i] = int.Parse(Console.ReadLine());
                    sum += array[i];
                }
                    result = sum;
                }
            if (choice == 6)
            {
                Console.Write("Введите размер массива");
                int countindex = int.Parse(Console.ReadLine());
                int[] array = new int[countindex];
                Console.Write("Массив: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            if (choice == 7)
            {
                Console.Write("Введите размер массива");
                int countindex = int.Parse(Console.ReadLine());
                int[] array = new int[countindex];
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                  if (array[i] > max)
                  max = array[i];
                }
                    result = max;
            }
            if (choice == 8)
            {

                Console.Write("Введите размер массива");
                int countindex = int.Parse(Console.ReadLine());
                int[] array = new int[countindex];
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                   {
                      if (array[i] < min)
                      min = array[i];
                    }
                    result = min;
            }
            if (choice == 9)
            {
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine());

                    long fact = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        fact *= i;
                    }
                    result = fact;
            }
            if (choice == 10)
            {
                    Console.Write("Введите делимое: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите делитель: ");
                    int num2 = int.Parse(Console.ReadLine());

                    if (num2 == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }

                    int quotient = num1 / num2;
                    int remainder = num1 % num2;
                result = quotient;
            }
            if (choice == 11)
            {
                    Console.Write("Введите процент: ");
                    double p = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение процента: ");
                    double part = double.Parse(Console.ReadLine());
                    result = part * 100 / p;
            }
                return result;
            }
    }
}

