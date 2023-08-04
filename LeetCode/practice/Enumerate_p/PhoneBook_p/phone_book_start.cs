using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Enumerate_p.PhoneBook_p
{
    internal class phone_book_start
    {

        class Contact
        {
            string name;
            string phoneNumber;
            public Contact(string name, string phoneNumber)
            {
                this.name = name;
                this.phoneNumber = phoneNumber;
            }

            public void Call()
            {
                Console.WriteLine($"Calling to {this.name}. Phone number is {this.phoneNumber}");
            }
        }

        public class PhoneBook : IEnumerable<Contact>
        {
            List<Contact> phonebook;

            public PhoneBook()
            {
                this.phonebook = new List<Contact>
                {
                    new Contact("Andre", "435797087"),
                    new Contact("Lisa", "435677087"),
                    new Contact("Dine", "3457697087"),
                    new Contact("Sofi", "4367697087")
                };
            }

            IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
            {
                return this.phonebook.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public static void Start()
            {
                PhoneBook MyPhoneBook = new PhoneBook();

                foreach (Contact contact in MyPhoneBook)
                {
                    contact.Call();
                }
            }
        }

    }
}
