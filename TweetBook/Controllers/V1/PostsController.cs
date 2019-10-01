using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TweetBook.Contracts.V1;
using TweetBook.Contracts.V1.Requests;
using TweetBook.Contracts.V1.Responses;
using TweetBook.Domain;

namespace TweetBook.Controllers.V1
{
    public class PostsController : Controller
    {

        public PostsController()
        {
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public IActionResult GetAll()
        {
            return Ok(_posts);
        }

        [HttpGet(ApiRoutes.Posts.Get)]
        public IActionResult Get([FromRoute]Guid postId)
        {
            var post = _posts.SingleOrDefault(p => p.Id == postId);

            if (post == null)
                return NotFound();

            return Ok(post);
        }

        [HttpPost(ApiRoutes.Posts.Create)]
        public IActionResult Create([FromBody]CreatePostRequest postRequest)
        {
            var post = new Post { Id = postRequest.Id };

            if (post.Id == Guid.Empty)
                postRequest.Id = Guid.NewGuid();

            _posts.Add(post);

            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + ApiRoutes.Posts.Get.Replace("{postId}", postRequest.Id.ToString());

            var response = new PostResponse { Id = post.Id };

            return Created(locationUri, response);
        }
    }
}
