using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_8_6
{
    internal class Phonebook
    {
        private Dictionary<string, string> phonebook = new Dictionary<string, string>();

        /// <summary>
        /// Метод итеративно предлагает пользователю вводить в программу номера телефонов и ФИО их владельцев.
        /// Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки. 
        /// </summary>
        public void InputPhoneNumbers()
        {
            string phoneNumber = " ";
            string fullName = " ";

            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("Введите номер телефона (если вы закончили вводить номера телефонов, просто нажмите Enter): ");
                phoneNumber = Console.ReadLine();

                if(phoneNumber.Equals(""))
                {
                    break;
                }          

                Console.WriteLine("Введите ФИО владельца: ");
                fullName = Console.ReadLine();

                if (fullName.Equals(""))
                {
                    break;
                }

                Console.WriteLine("-------------------------------------------------------------------------------------------");

                if(!phonebook.ContainsKey(phoneNumber))
                {
                    phonebook.Add(phoneNumber, fullName);
                }
                else
                {
                    Console.WriteLine("Такой номер уже существует, пожалуйста, введите другой номер!");
                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter, что бы попробовать снова...");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Пользователь вводит номер телефона и ему выдаётся ФИО владельца, после чего приложение закрывается. 
        /// </summary>
        public void OutputPhoneNumbersOwner()
        {
            string phoneNumber = " ";
            string value = "";
            bool correctNumber = false;            

            while(!correctNumber)
            {
                if (phonebook.Count == 0)
                {
                    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    Console.WriteLine($"Записная книжка пуста! Нужно перезапустить приложение!");
                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter, что бы выйти...");
                    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("Введите номер телефона, что бы найти его владельца: ");
                phoneNumber = Console.ReadLine();                

                if (phonebook.TryGetValue(phoneNumber, out value))
                {
                    Console.WriteLine();
                    string name = phonebook[phoneNumber];
                    correctNumber = true;
                    Console.WriteLine();
                    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    Console.WriteLine($"Владельцем номера {phoneNumber} является {name}");
                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter, что бы выйти...");
                    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine();
                    correctNumber = false;
                    Console.WriteLine($"Номер {phoneNumber} остутсвует в телефонной книге! Проверьте правильность введенного номера!");
                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter, что бы попробовать снова...");
                    Console.ReadKey();
                }
            }            
        }
    }
}
