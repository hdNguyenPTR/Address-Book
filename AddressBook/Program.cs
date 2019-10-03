using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
    /*        var b = new BusinessContact
            {
                Name = "Business Contact",
                PhoneNumber = "+61 2 321",
                Company = "Contacts r Us",
                FaxNumber = "Who has a fax nowadays?"
            };

            

            Console.WriteLine("--------------------");

            var p = new PersonalContact
            {
                Name = "pers Con",
                PhoneNumber = "+61 2 456",
                Address = "123 Contacts Way"
            };
*/
            var book = Address.LoadXML("addressXML.xml");
/*            book.Save("addressXML.xml", book);*/
            Console.WriteLine("shoud load here");
            Console.WriteLine("--------------------");
            foreach (var desc in book.GetDescriptions())
            {
                Console.WriteLine(desc);
            }
            Console.WriteLine("\r\nPress any Key to continue");
            Console.ReadLine();

            var menu = new Menu();
            menu.MainMenu();
            
            Console.ReadLine();


        }
    }
}
