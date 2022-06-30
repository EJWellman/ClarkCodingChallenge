using ClarkCodingChallenge.BusinessModels;
using System.Collections.Generic;

namespace ClarkCodingChallenge.DataAccess
{
    public interface IContactsDataAccess
    {
        void AddContact(Contact contact);
        List<Contact> RetrieveContacts(string lastName = "", bool descending = false);
    }
}
