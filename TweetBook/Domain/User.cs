using Microsoft.AspNetCore.Identity;
using System;

namespace TweetBook.Domain
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
