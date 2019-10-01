using System;
using System.Collections.Generic;
using System.Linq;
using TweetBook.Domain;

namespace TweetBook.Services
{
    public class PostService : IPostService
    {
        private readonly List<Post> _posts;

        public PostService()
        {
            _posts = new List<Post>();

            for (int i = 0; i < 5; i++)
            {
                _posts.Add(new Post
                {
                    Id = Guid.NewGuid(),
                    Name = $"Name for post n°{i + 1}"
                });
            }
        }

        public Post GetPostById(Guid postId)
        {
            return _posts.SingleOrDefault(p => p.Id == postId);
        }

        public List<Post> GetPosts()
        {
            return _posts;
        }
    }
}
