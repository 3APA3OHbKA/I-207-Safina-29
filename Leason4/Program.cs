using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leason4
{
    internal class Program
    {
        static void Main()
        {
            Person clsperson = new Person();
            Console.WriteLine($"Name: {clsperson.name}");
            Console.WriteLine($"age: {clsperson.age}");
            Console.WriteLine($"birthday: {clsperson.birthday:dd.M.yyyy}");
            Console.WriteLine($"gender: {clsperson.gender}");
            Console.WriteLine($"height_cm: {clsperson.height_cm}");
            Console.WriteLine($"weight_kg: {clsperson.weight_kg}");
            Console.WriteLine($"loveColor: {clsperson.loveColor}");
        }
    }
}

