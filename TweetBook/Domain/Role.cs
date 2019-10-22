using Microsoft.AspNetCore.Identity;
using System;

namespace TweetBook.Domain
{
    public class Role : IdentityRole<Guid>
    {
        public const string ADMIN = "Admin";
        public const string MANAGER = "Manager";
        public const string OPERATOR = "User";
        public const string OBSERVER = "Observer";
    }
}
