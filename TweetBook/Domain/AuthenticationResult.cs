using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TweetBook.Domain
{
    public class AuthenticationResult
    {
        public string Token { get; set; }

        public bool Success { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
