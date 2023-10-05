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
            // Задание 1. Работа с листом        
            //Task1List();

            // Задание 2. Телефонная книга
            //Task2Phonebook();

            // Задание 3. Проверка повторов
            //Task3Duplicates();

            Task4Jotter();
        }

        /// <summary>
        /// Задание 1. Работа с листом
        /// </summary>
        public static void Task1List()
        {
            Console.WriteLine("Задание 1. Работа с листом");

            WorkWithList workWithList = new WorkWithList();

            workWithList.FillTheList();
            workWithList.PrintList("Полный лист");

            workWithList.DeleteNumbers();
            workWithList.PrintList("После удаления чисел > 25 и < 50");

            Console.ReadKey();
        }

        /// <summary>
        /// Задание 2. Телефонная книга
        /// </summary>
        public static void Task2Phonebook()
        {
            Console.WriteLine("Задание 2. Телефонная книга");

            Phonebook phonebook = new Phonebook();

            phonebook.InputPhoneNumbers();
            phonebook.OutputPhoneNumbersOwner();
        }

        /// <summary>
        /// Задание 3. Проверка повторов
        /// </summary>
        public static void Task3Duplicates()
        {
            CheckForDuplicates checkForDuplicates = new CheckForDuplicates();

            checkForDuplicates.addNumber();
        }

        /// <summary>
        /// Задание 4. Записная книжка
        /// </summary>
        public static void Task4Jotter()
        {
            Jotter jotter = new Jotter();
            jotter.FillInContactInfo();
            jotter.SaveContactInfoToXml();
        }
    }
}
