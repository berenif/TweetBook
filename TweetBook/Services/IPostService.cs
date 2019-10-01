using System;
using System.Collections.Generic;
using TweetBook.Domain;

namespace TweetBook.Services
{
    public interface IPostService
    {
        List<Post> GetPosts();

        Post GetPostById(Guid postId);
    }
}
