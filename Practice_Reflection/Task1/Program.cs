using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Console;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.С помощью рефлексии вызвать метод Substring класса String и извлечь из строки подстроку заданного размера.
            */
            MethodInfo method = typeof(String).GetMethod("Substring", new Type[] { typeof(int)});
            Object subString = method.Invoke("My name is Alisher", new Object[] { 11 });
            WriteLine("{0}\n{1}", method, subString);
            ReadLine();
        }
    }
}
