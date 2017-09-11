using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeTask2
{
    class Program
    {
         /*
         2.	Описать класс с несколькими свойствами. Создать экземпляр класса и инициализировать его свойства. 
         С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. 
         Вывести полученные значения на экран
         */
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 0;
            student.Name = "Алишер";
            student.Surname = "Бекмухамбет";
            student.Specialty = "программист";
            Type type = student.GetType();
            foreach (var info in type.GetProperties())
            {
                Write(info.Name + " : ");
                WriteLine(info.GetValue(student));
            }
            ReadLine();
        }
    }
}
