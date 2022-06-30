using ClarkCodingChallenge.BusinessModels;
using System;
using System.Collections.Generic;

namespace ClarkCodingChallenge.Storage
{
    public class TemporaryContactStorage : IContactStorage
    {
        private List<Contact> _contacts;
        public List<Contact> Contacts
        {
            get
            {
                if(_contacts == null)
                {
                    _contacts = GenerateSeedData();
                }
                return _contacts;
            }
            set
            {
                _contacts = value;
            }
        }

        private List<Contact> GenerateSeedData()
        {
            List<Contact> ret = new List<Contact>()
            {
                new Contact() { FirstName = "Eric", LastName = "Wellman", EmailAddress = "Eric.J.Wellman@gmail.com" },
                new Contact() { FirstName = "John", LastName = "Smith", EmailAddress = "John@smith.com" },
                new Contact() { FirstName = "Derek", LastName = "Wellman", EmailAddress = "Derek@Wellman.com" }
            };

            return ret;
        }
    }
}
