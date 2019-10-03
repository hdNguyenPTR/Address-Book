using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    [Serializable]
    public abstract class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    [Serializable]
    public class BusinessContact : Contact
    {
        public String Company { get; set; }
        public String FaxNumber { get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}, Phone: {1},Company {2},Fax {3}", Name, PhoneNumber, Company, FaxNumber);
        }
    }

    [Serializable]
    public class PersonalContact : Contact
    {
        public string Address { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", Name, PhoneNumber, Address);
        }
    }
}
