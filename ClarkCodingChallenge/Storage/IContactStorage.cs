using ClarkCodingChallenge.BusinessModels;
using System.Collections.Generic;

namespace ClarkCodingChallenge.Storage
{
    public interface IContactStorage
    {
        //TODO: Remove this when actual storage is set up.
        public List<Contact> Contacts { get; set; }
    }
}