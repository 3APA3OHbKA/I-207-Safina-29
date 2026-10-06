namespace CalculatorVer04
{
    internal class Program
    {
        public void Main()
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
            Math math = new Math();
            double result = Math.Execute(choice);
            Console.WriteLine(result);
        }
    }
}
