namespace Calculate
{
    class Math
    {
        public void Main()
        {
            bool continueWork = true;

            while (continueWork)
            {
                Console.WriteLine("0  - Счёт процентов");
                Console.WriteLine("1  - Умножение");
                Console.WriteLine("2  - Деление");
                Console.WriteLine("3  - Вычитание");
                Console.WriteLine("4  - Сложение");
                Console.WriteLine("5  - Сумма массива");
                Console.WriteLine("6  - Работа с массивом (вывод)");
                Console.WriteLine("7  - Максимум массива");
                Console.WriteLine("8  - Минимум массива");
                Console.WriteLine("9  - Факториал");
                Console.WriteLine("10 - Деление с остатком и целочисленное");
                Console.WriteLine("11 - Обратное процентам (найти число по проценту)");
                Console.Write("Выберите задачу: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0: Percent(); break;
                    case 1: Multiply(); break;
                    case 2: Divide(); break;
                    case 3: Subtract(); break;
                    case 4: Add(); break;
                    case 5: ArraySum(); break;
                    case 6: ArrayPrint(); break;
                    case 7: ArrayMax(); break;
                    case 8: ArrayMin(); break;
                    case 9: Factorial(); break;
                    case 10: DivideWithRemainder(); break;
                    case 11: ReversePercent(); break;
                    case 12: ArraySort(); break;
                    default: Console.WriteLine("Неверный выбор!"); break;
                }

            }

            static void Percent()
            {
                Console.Write("Введите число: ");
                double num = double.Parse(Console.ReadLine());
                Console.Write("Введите процент (%): ");
                double percent = double.Parse(Console.ReadLine());

                double result = num * percent / 100;
                Console.WriteLine($"{percent}% от {num} = {result}");
            }

            static void ReversePercent()
            {
                Console.Write("Введите значение (часть): ");
                double part = double.Parse(Console.ReadLine());
                Console.Write("Введите процент (%): ");
                double percent = double.Parse(Console.ReadLine());

                double result = part * 100 / percent;
                Console.WriteLine($"Если {percent}% = {part}, то целое = {result}");
            }
            static void Multiply()
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            static void Divide()
            {
                Console.Write("Введите делимое: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите делитель: ");
                double num2 = double.Parse(Console.ReadLine());

                if (num2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    return;
                }
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            static void Subtract()
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            static void Add()
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            static int[] ReadArray()
            {
                Console.Write("Введите размер массива: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Элемент [{i}]: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                return arr;
            }
            static void ArraySum()
            {
                int[] arr = ReadArray();
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine($"Сумма элементов массива = {sum}");
            }
            static void ArrayPrint()
            {
                int[] arr = ReadArray();
                Console.Write("Массив: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            static void ArrayMax()
            {
                int[] arr = ReadArray();
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max) max = arr[i];
                }
                Console.WriteLine($"Максимум = {max}");
            }
            static void ArrayMin()
            {
                int[] arr = ReadArray();
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min) min = arr[i];
                }
                Console.WriteLine($"Минимум = {min}");
            }
            static void Factorial()
            {
                Console.Write("Введите число: ");
                int n = int.Parse(Console.ReadLine());

                long fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine($"{n}! = {fact}");
            }
            static void DivideWithRemainder()
            {
                Console.Write("Введите делимое: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите делитель: ");
                int b = int.Parse(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    return;
                }

                int quotient = a / b;
                int remainder = a % b;

                Console.WriteLine($"{a} / {b} = {quotient} (остаток {remainder})");
                Console.WriteLine($"Целочисленное: {quotient}");
                Console.WriteLine($"Остаток: {remainder}");
            }
            static void ArraySort()
            {
                int[] arr = ReadArray();
                Array.Sort(arr);

                Console.Write("Отсортированный массив: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}