using AlternativeAssignment5_ContactRegistry.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeAssignment5_ContactRegistry.ContactFiles
{
    public class Contact
    {
        private string _firstname;
        private string _lastname;
        private Address _address;

        public Contact()
        {
            _firstname = "";
            _lastname = "";
            _address = new Address();
        }

        public Contact(string firstname, string lastname, string street, string city, string zip, CountryNames country)
        {
            _firstname = firstname;
            _lastname = lastname;
            _address = new Address(street, zip, city, country);
        }

        public Contact(string firstname, string lastname, Address address) 
        {
            _firstname = firstname;
            _lastname = lastname;
            _address = address;
        }

        public string Name
        {
            get
            {
                return _firstname + " " + _lastname;
            }

            set
            {
                this._firstname = value.Split(' ')[0];
                this._lastname = value.Split(' ')[1];
            }
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }

            set
            {
                this._firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastname;
            }

            set
            {
                this._lastname = value;
            }
        }

        public Address Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }

        public override string ToString()
        {
            string contact = string.Format("{0, -20} {1}", _firstname + " " + _lastname, this._address.ToString());
            return contact;
        }
    }
}
