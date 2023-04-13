using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Задание 1. Работа с листом
            Console.WriteLine("Задание 1. Работа с листом");
            
            WorkWithList workWithList = new WorkWithList();

            workWithList.FillTheList();
            workWithList.PrintList("Полный лист");

            workWithList.DeleteNumbers();
            workWithList.PrintList("После удаления чисел > 25 и < 50");

            Console.ReadKey();
        }
    }
}
