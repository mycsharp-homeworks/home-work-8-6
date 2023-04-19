using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8_6
{
    class CheckForDuplicates
    {
        HashSet<string> ints = new HashSet<string>();
        string number = " ";

        /// <summary>
        /// Пользователь вводит число. 
        ///  Если такое число уже присутствует в коллекции, то пользователю на экран выводится сообщение, что число уже вводилось ранее. 
        ///  Если числа нет, то появляется сообщение о том, что число успешно сохранено. 
        /// </summary>
        public void addNumber()
        {
            while (true)
            {
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("Введите число (Нажмите Enter, если вы закончили вводить числа): ");
                number = Console.ReadLine();

                if (number.Equals(""))
                {
                    break;
                }

                if (!ints.Contains(number))
                {
                    ints.Add(number);
                    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                    Console.WriteLine("Число было успешно сохранено!");
                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter, что бы продолжить!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                    Console.WriteLine("Такое число уже вводилось ранее! Введите другое!");
                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter, что бы продолжить!");
                    Console.ReadKey();
                }
            }
        }
    } 
}
