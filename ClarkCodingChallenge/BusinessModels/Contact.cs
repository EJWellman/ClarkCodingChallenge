using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace ClarkCodingChallenge.BusinessModels
{
    public class Contact
    {
        [Required]
        [MinLength (1)]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //TODO: Confirm that the 'EmailAddress' attribute actually validates email addresses correctly, if not, write better validation
        // Deemed 'good enough' from initial testing
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get;set; }
    }
}
