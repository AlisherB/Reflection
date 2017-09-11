using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Console;

namespace Task2
{
    class Program
    {
        /*
         2.	Получить список конструкторов класса List<T>
        */
        static void Main(string[] args)
        {
            ConstructorInfo[] constructors = typeof(List<>).GetConstructors();
            for (int i = 0; i < constructors.Length; i++)
            {
                WriteLine(constructors[i]);
            }
            ReadLine();
        }
    }
}
