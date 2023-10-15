using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace BusinessObject
{
    public class Member
    {
        public string Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

    }
}