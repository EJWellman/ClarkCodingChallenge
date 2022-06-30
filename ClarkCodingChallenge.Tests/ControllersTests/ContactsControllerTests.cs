using ClarkCodingChallenge.BusinessModels;
using ClarkCodingChallenge.DataAccess;
using ClarkCodingChallenge.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallenge.Tests.ControllerTest
{
    [TestClass]
    public class ContactsControllerTests
    {
        [TestMethod]
        public void TestAddingContacts()
        {
            IContactsDataAccess _dataAccess = new ContactsDataAccess(new TemporaryContactStorage());

            int startCount = _dataAccess.RetrieveContacts().Count;

            _dataAccess.AddContact(new Contact() { FirstName = "Jennifer", LastName = "Wellman", EmailAddress = "Jennifer@Wellman.com" });

            Assert.IsTrue(_dataAccess.RetrieveContacts().Count == startCount + 1);
        }

        [TestMethod]
        public void TestOrderingContacts()
        {
            IContactsDataAccess _dataAccess = new ContactsDataAccess(new TemporaryContactStorage());

            int startCount = _dataAccess.RetrieveContacts().Count;

            _dataAccess.AddContact(new Contact() { FirstName = "Jennifer", LastName = "Wellman", EmailAddress = "Jennifer@Wellman.com" });
            _dataAccess.AddContact(new Contact() { FirstName = "Ralph", LastName = "Smith", EmailAddress = "Ralph@smith.com" });
            _dataAccess.AddContact(new Contact() { FirstName = "Charles", LastName = "Wellman", EmailAddress = "Charles@Wellman.com" });

            int afterAddCount = _dataAccess.RetrieveContacts().Count;

            Assert.IsTrue(afterAddCount == startCount + 3);

            List<Contact> dataAsc = _dataAccess.RetrieveContacts("Wellman");
            Assert.IsFalse(dataAsc.First().FirstName == "Jennifer");
            Assert.IsTrue(dataAsc.Last().FirstName == "Jennifer");

            List<Contact> dataDesc = _dataAccess.RetrieveContacts("Wellman", true);
            Assert.IsFalse(dataDesc.First().FirstName == "Charles");
            Assert.IsTrue(dataDesc.Last().FirstName == "Charles");
        }
    }
}
