using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TweetBook.Domain
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
