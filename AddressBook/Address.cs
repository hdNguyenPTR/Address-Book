using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace AddressBook
{
    [Serializable]
    public class Address
    {
        private readonly List<Contact> contacts = new List<Contact>();
        public List<Contact> People { get { return contacts; } }

        public void AddContact(Contact c)
        {
            contacts.Add(c);
        }

        public void ListAll()
        {
            foreach (Contact id in contacts)
            {
                Console.WriteLine(id.ToString());
            }
        }

        public Contact Search(String s)
        {
            return contacts.FirstOrDefault(cont => cont.Name == s);            
        }

        public void Save(string file, Address adr)
        {
            //if(File.Exists(file))
            //{
                using(var stream = File.OpenWrite(file))
                {
                    var ab = new XmlSerializer(typeof(Address), new[] { typeof(PersonalContact), typeof(BusinessContact) });
                    ab.Serialize(stream,adr);
                }
            //}
        }

        public static Address LoadXML(string fileName)
        {
            var book = new Address();
            if(File.Exists(fileName))
            {
                using(var stream = File.OpenRead(fileName))
                {
                    var ab = new XmlSerializer(typeof(Address), new[] { typeof(PersonalContact), typeof(BusinessContact) });
                    book = (Address)ab.Deserialize(stream);
                }
            }
            return book;
        }

        public IEnumerable<string> GetDescriptions()
        {
            return from contact in contacts
                select contact.ToString();

            //return _contacts.Select(x => x.ToString());

            //var listOfDescriptions = new List<string>();
            //foreach (var c in _contacts)
            //{
            //    listOfDescriptions.Add(c.ToString());
            //}

            //return listOfDescriptions;
        }
    }
}
