using System;
using System.Collections.Generic;
using System.Text;

namespace Leason3
{
    public class Person
    {
        static FileName clsperson = new FileName();
       public static void Main()
        {
            Console.WriteLine($"Name: {clsperson.Name}\n " +
                $"age: {clsperson.age}\n " +
                $"birthday: {clsperson.birthday} \n " +
                $"Gender: {clsperson.gender} \n " +
                $"loveColor: {clsperson.loveColor}\n " +
                $"height_cm: {clsperson.height_cm} \n " +
                $"weight_kg: {clsperson.weight_kg}");
        }
    }
}
