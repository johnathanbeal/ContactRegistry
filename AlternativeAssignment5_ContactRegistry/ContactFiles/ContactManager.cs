using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeAssignment5_ContactRegistry.ContactFiles
{
    public static class ContactManager
    {
        public static List<Contact> Registry { get; set; }

        static ContactManager()
        {
            Registry = new List<Contact>();
        }

        public static void AddContactToRegistry(Contact contact)
        {
            Registry.Add(contact);
        }

        public static Contact GetContactFromRegistryByFirstNameAndLastName(string firstName, string lastName)
        {
            return Registry.Where(r => r.FirstName == firstName && r.LastName == lastName).FirstOrDefault();
        }

        public static Contact GetContactFromRegistryByAddress(string street, string city, string zip, CountryNames country)
        {
            var contact = Registry.Where(r => r.Address.StreetAddress == street && r.Address.City == city
            && r.Address.ZipCode == zip).ToList();

            if (contact.Count > 1)
            {
                contact = Registry.Where(r => r.Address.StreetAddress == street && r.Address.City == city
                && r.Address.ZipCode == zip && r.Address.Country == country).ToList();
            }

            return contact.FirstOrDefault();
        }

        public static Contact GetContactFromRegistry(int? index)
        {
            return Registry[(int)index];
        }

        public static Contact UpdateContact(int index, Contact contact)
        {
            Registry[index].FirstName = contact.FirstName ?? Registry[index].Name.Split(' ')[0]; 
            Registry[index].LastName = contact.LastName ?? Registry[index].Name.Split(' ')[1];
            Registry[index].Address.StreetAddress = contact.Address.StreetAddress ?? Registry[index].Address.StreetAddress;
            Registry[index].Address.City = contact.Address.City ?? Registry[index].Address.City;
            Registry[index].Address.ZipCode = contact.Address.ZipCode ?? Registry[index].Address.ZipCode;
            Registry[index].Address.Country = contact.Address.Country;

            return Registry[index];
        }

        public static void RemoveContactFromRegistry(Contact contact)
        {
            Registry.Remove(contact);
        }

        public static void RemoveContactFromRegistry(int index)
        {
            Registry.RemoveAt(index);
        }

        public static int RegistryCount()
        {
            return Registry.Count;
        }
    }
}
