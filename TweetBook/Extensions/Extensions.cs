using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace TweetBook.Extensions
{
    public static class Extensions
    {
        public static Guid GetUserId(this HttpContext httpContext)
        {
            return new Guid(httpContext.User.Claims.Single(x => x.Type == "id").Value);
        }
    }
}