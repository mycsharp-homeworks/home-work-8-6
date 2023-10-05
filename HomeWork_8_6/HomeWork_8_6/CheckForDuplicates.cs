using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8_6
{
    class CheckForDuplicates
    {
        private HashSet<string> ints = new HashSet<string>();
        private string number = " ";

        /// <summary>
        /// Пользователь вводит число. 
        ///  Если такое число уже присутствует в коллекции, то пользователю на экран выводится сообщение, что число уже вводилось ранее. 
        ///  Если числа нет, то появляется сообщение о том, что число успешно сохранено. 
        /// </summary>
        public void addNumber()
        {
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Введите число (Нажмите Enter, если вы закончили вводить числа):");
                number = Console.ReadLine();

                if (number.Equals(""))
                {
                    break;
                }

                if (!ints.Contains(number))
                {
                    ints.Add(number);
                    Console.WriteLine("___________________________________________________________________");
                    Console.WriteLine("|                  Число было успешно сохранено!                  |");
                }
                else
                {
                    Console.WriteLine("___________________________________________________________________");
                    Console.WriteLine("|         Такое число уже вводилось ранее! Введите другое!        |");             }
            }
        }
    } 
}
