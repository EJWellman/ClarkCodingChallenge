using ClarkCodingChallenge.BusinessModels;
using ClarkCodingChallenge.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClarkCodingChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailingListController : ControllerBase
    {
        private readonly IContactsDataAccess _dataAccess;

        public MailingListController(IContactsDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        // GET api/<MailingListController>
        [HttpGet]
        public List<Contact> Get(string lastName, bool descending)
        {
            return _dataAccess.RetrieveContacts(lastName, descending);
        }
    }
}
