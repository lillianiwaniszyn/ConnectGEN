using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Contacts
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string ImageEx { get; set; }
        public Contacts[] CurrentContacts { get; set; }

        public Contacts(string name, string userName, string imageEx, Contacts[] currentContacts)
        {
            Name = name;
            UserName = userName;
            ImageEx = imageEx;
            CurrentContacts = currentContacts; 
        }
    }
}
