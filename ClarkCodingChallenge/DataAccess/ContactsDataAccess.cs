using ClarkCodingChallenge.BusinessModels;
using ClarkCodingChallenge.Storage;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallenge.DataAccess
{
    public class ContactsDataAccess : IContactsDataAccess
    {
        private readonly IContactStorage _contactStorage;

        public ContactsDataAccess(IContactStorage contactStorage)
        {
            _contactStorage = contactStorage;
        }

        public List<Contact> RetrieveContacts(string lastName, bool descending)
        {
            List<Contact> returnContacts = new List<Contact>();
            if (_contactStorage.Contacts.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    returnContacts.AddRange(_contactStorage.Contacts.Where(c => c.LastName.Equals(lastName, System.StringComparison.CurrentCultureIgnoreCase)));
                }
                else
                {
                    returnContacts.AddRange(_contactStorage.Contacts);
                }
            }
            returnContacts.Sort((x, y) =>
            {
                int lastNameRet = string.Compare(x.LastName, y.LastName);
                return lastNameRet != 0 ? lastNameRet : x.FirstName.CompareTo(y.FirstName);
            });
            if (descending)
            {
                returnContacts.Reverse();
            }

            return returnContacts;
        }

        public void AddContact(Contact contact)
        {
            _contactStorage.Contacts.Add(contact);
        }
    }
}
