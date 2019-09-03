using AlternativeAssignment5_ContactRegistry.ContactFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlternativeAssignment5_ContactRegistry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContactManager contactManager;
        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
            contactManager = new ContactManager();
        }

        public void InitializeGUI()
        {
            var countries = Enum.GetValues(typeof(CountryNames));
            foreach (var countryName in countries)
            {
                countryComboBox.Items.Add(countryName);
            }
            countryComboBox.SelectedItem = CountryNames.United_States_of_America;
            deleteButton.IsEnabled = false;
            changeButton.IsEnabled = false;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var firstname = firstNameTextBox.Text;
            var lastname = lastNameTextBox.Text;
            var street = streetTextBox.Text;
            var city = cityTextBox.Text;
            var zip = zipTextBox.Text;
            CountryNames country = (CountryNames)countryComboBox.SelectedItem;
            Contact addContact = new Contact();
            Address contactAddress = new Address(street, city, zip, country);
            try
            {
                addContact = new Contact(firstname, lastname, street, city, zip, country);
            }
            catch
            {
                addContact = new Contact(firstname, lastname, contactAddress);
            }
            finally
            {
                contactManager.AddContactToRegistry(addContact);
                listOfContacts.Items.Add(addContact.ToString());
            }
            registeredCountTextBox.Text = contactManager.RegistryCount().ToString();
        }

        //I don't understand why this method is called by the change method
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int? index = listOfContacts.SelectedIndex;

            if (index == null)
            {
                MessageBox.Show("Please select a contact");
            }
            else if (index < 0)
            {
                
            }
            else
            {
                addButton.IsEnabled = false;
                changeButton.IsEnabled = true;
                deleteButton.IsEnabled = true;

                Contact contact = new Contact();
                try
                {
                    contact = contactManager.GetContactFromRegistry(index);
                }
                catch
                {
                    contact = contactManager.GetContactFromRegistryByFirstNameAndLastName(firstNameTextBox.Text.Trim(), lastNameTextBox.Text.Trim());
                }
                finally
                {
                    firstNameTextBox.Text = contact.FirstName ?? contact.Name.Split(' ')[0]; 
                    lastNameTextBox.Text = contact.LastName ?? contact.Name.Split(' ')[1]; 
                    streetTextBox.Text = contact.Address.StreetAddress;
                    cityTextBox.Text = contact.Address.City;
                    zipTextBox.Text = contact.Address.ZipCode;
                    countryComboBox.SelectedItem = contact.Address.Country;
                }               
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var contactIndex = listOfContacts.SelectedIndex;
            Contact removeContact = new Contact();
            
                    removeContact = contactManager.GetContactFromRegistryByAddress
                    (streetTextBox.Text,
                    cityTextBox.Text,
                    zipTextBox.Text,
                    (CountryNames)countryComboBox.SelectedItem);
            
            if (contactIndex >= 0 && contactIndex <= contactManager.RegistryCount())
            {
                try
                {
                    contactManager.RemoveContactFromRegistry(contactIndex);
                }
                catch
                {
                    contactManager.RemoveContactFromRegistry(removeContact);
                }
                finally
                {
                    var contactInfo = listOfContacts.SelectedItem;
                    listOfContacts.Items.Remove(contactInfo);
                }         
            }
            else
            {
                MessageBox.Show("Please select a contact");

            }

            registeredCountTextBox.Text = contactManager.RegistryCount().ToString();
            addButton.IsEnabled = true;
            changeButton.IsEnabled = false;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            zipTextBox.Text = "";
            countryComboBox.SelectedItem = CountryNames.United_States_of_America;
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {       
                Contact updateContact = new Contact();
                var index = listOfContacts.SelectedIndex;
                if (index < 0)
                {
                    MessageBox.Show("Please select a contact");
                }
                else
                {
                    updateContact.FirstName = firstNameTextBox.Text;
                    updateContact.LastName = lastNameTextBox.Text;
                    updateContact.Address.StreetAddress = streetTextBox.Text;
                    updateContact.Address.City = cityTextBox.Text;
                    updateContact.Address.ZipCode = zipTextBox.Text;
                    updateContact.Address.Country = (CountryNames)countryComboBox.SelectedItem;

                    contactManager.UpdateContact(index, updateContact);
                    listOfContacts.Items.RemoveAt(index);

                    listOfContacts.Items.Insert(index, updateContact.ToString());

                    registeredCountTextBox.Text = contactManager.RegistryCount().ToString();
                    addButton.IsEnabled = true;
                    changeButton.IsEnabled = false;
                    deleteButton.IsEnabled = false;
                }
        }

        private void CountryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            countryComboBox.SelectedItem = countryComboBox.SelectedItem;
        }
    }
}
