Console.Write("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число");
string input = Console.ReadLine();
int num2 = int.Parse(input);
Console.WriteLine("Введите знак");
string sign = Console.ReadLine();

if (sign == "+")
    Console.WriteLine(num1 + num2);
else if (sign == "-")
    Console.WriteLine(num1 - num2);
else if (sign == "*")
    Console.WriteLine(num1 * num2);
else if (sign == "/")
    Console.WriteLine(num1 / num2);
else
    Console.WriteLine("Ошибка");
