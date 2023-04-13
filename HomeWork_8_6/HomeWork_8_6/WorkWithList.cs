using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8_6
{
    class WorkWithList
    {
        public List<int> ints = new List<int>();

        /// <summary>
        /// Метод заполняет лист 100 случайными числами в диапазоне от 0 до 100.
        /// </summary>
        public void FillTheList()
        {
            Random rand = new Random();

            for (int i = 0; i <= 100; i++)
            {
                int randomNumber = rand.Next(0, 101);
                ints.Add(randomNumber);
            }
        }

        /// <summary>
        /// Метод удаляет из листа числа, которые больше 25, но меньше 50. 
        /// </summary>
        public void DeleteNumbers()
        {
            int num1 = 25;
            int num2 = 50;

            // Считываем лист задом наперед. Если идти вперед, то можно упустить некоторые числа,
            // так как при удалении элементов, список сдвигается влево, меняя индекс следующего числа и может перепрыгнуть через нужное число.
            for (int i = ints.Count - 1; i >= 0; i--)
            {
                if(ints[i] > num1 && ints[i] < num2)
                {
                    ints.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Метод выводит числа из листа на экран. 
        /// </summary>
        public void PrintList(string message)
        {
            Console.WriteLine("\n");
            Console.WriteLine(message + ":");
            foreach (var number in ints)
            {
                Console.Write(number + " ");
            }                       
        }
    }
}
