using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace HomeWork_8_6
{
    internal class Jotter
    {
        private string fullName;
        private string streetName;
        private string homeNumber;
        private string flatNumber;
        private string mobilePhoneNumber;
        private string landLineNumber;

        public void FillInContactInfo()
        {
            Console.WriteLine("Введите ФИО вашего контакта:");
            fullName = Console.ReadLine();
            Console.WriteLine("Введите название улицы вашего контакта:");
            streetName = Console.ReadLine();
            Console.WriteLine("Введите номер дома вашего контакта:");
            homeNumber = Console.ReadLine();
            Console.WriteLine("Введите номер квартира вашего контакта:");
            flatNumber = Console.ReadLine();
            Console.WriteLine("Введите номер мобильного телефона вашего контакта:");
            mobilePhoneNumber = Console.ReadLine();
            Console.WriteLine("Введите номер домашнего телефона вашего контакта:");
            landLineNumber = Console.ReadLine();
        }

        public void SaveContactInfoToXml() 
        { 
            XDocument jotterXML = new XDocument(
                new XElement("Person",
                    new XAttribute("name", fullName),
                        new XElement("Address",
                            new XElement("Street", streetName),
                            new XElement("HomeNumber", homeNumber),
                            new XElement("FlatNumber", flatNumber)
                        ),
                    new XElement("Phones",
                        new XElement("MobilePhoneNumber", mobilePhoneNumber),
                        new XElement("LandLineNumber", landLineNumber)
                    )
                )                
            );

            jotterXML.Save("jotter.xml");
            Console.WriteLine("XML файл был сохранен!");
            Console.ReadKey();
        }
    }
}
