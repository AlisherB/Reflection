using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Console;

namespace HomeTask1
{
    class Program
    {
        /*
        1.	С помощью рефлексии получить список методов класса Console и вывести на экран.
        */
        static void Main(string[] args)
        {
            Type type = typeof(Console);
            foreach (var methods in type.GetMethods())
            {
                WriteLine(methods.DeclaringType + " " + methods.MemberType + " " + methods.Name);
            }
            ReadLine();
        }
    }
}
