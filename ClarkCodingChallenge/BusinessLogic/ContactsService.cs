using ClarkCodingChallenge.BusinessModels;
using ClarkCodingChallenge.DataAccess;
using System.Collections.Generic;

namespace ClarkCodingChallenge.BusinessLogic
{
    public class ContactsService
    {
        private readonly IContactsDataAccess _contactStorageProvider;

        public ContactsService(IContactsDataAccess contactStorageProvider)
        {
            _contactStorageProvider = contactStorageProvider;
        }

        public void AddContact(Contact contact)
        {
            _contactStorageProvider.AddContact(contact);
        }

        public List<Contact> RetrieveContacts(string lastName = "", bool descending = false)
        {
            return _contactStorageProvider.RetrieveContacts(lastName, descending);
        }

        //TODO: Place business logic for contact here
    }
}
