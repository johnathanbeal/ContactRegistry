using AlternativeAssignment5_ContactRegistry.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeAssignment5_ContactRegistry.ContactFiles
{
    public class Address
    {
        private string _streetAddress;
        private string _zipCode;
        private string _city;
        private CountryNames _country;


        public string StreetAddress
        {
            get
            {
                return this._streetAddress;
            }
            set
            {
                this._streetAddress = value;
            }
        }
        public string ZipCode
        {
            get
            {
                return this._zipCode;
            }
            set
            {
                this._zipCode = value;
            }
        }
        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }
        public CountryNames Country
        {
            get
            {
                return this._country;
            }
            set
            {
                this._country = value;
            }
        }

        public Address()
        {
            _streetAddress = "";
            _zipCode = "";
            _city = "";
            _country = CountryNames.Afghanistan;
        }

        public Address(string street, string zip, string city) : this(street, zip, city, CountryNames.United_States_of_America)
        {
            
        }

        public Address(string street, string zip, string city, CountryNames country)
        {
            _streetAddress = street;
            _zipCode = zip;
            _city = city;
            _country = country;
        }

        public override string ToString()
        {
            return this.StreetAddress + AddSpaces.addSpace(40 - StreetAddress.Length)
                + this.City + AddSpaces.addSpace(40 - City.Length)
                + this.ZipCode + AddSpaces.addSpace(20 - ZipCode.Length)
                + this.Country;
        }

    }
}
