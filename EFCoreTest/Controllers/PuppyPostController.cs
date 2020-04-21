using System.Collections.Generic;
using EFCoreTest.Models;
using EFCoreTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PuppyPostController : ControllerBase
    {
        readonly PuppyPostsDataServices _puppyService;
        public PuppyPostController(PuppyPostsDataServices puppyService)
        {
            _puppyService = puppyService;
        }

        [HttpGet, Authorize]
        public IEnumerable<PuppyPost> GetPuppyPosts()
        {
            return _puppyService.GetPuppyPosts();
        }

        [HttpGet("{id}")]
        public PuppyPost GetPost(int id)
        {
            return _puppyService.GetPostById(id);
        }

        [HttpPost]
        public int CreatePost(PuppyPost postToAdd)
        {
            return _puppyService.CreatePost(postToAdd);
        }

        [HttpPost("update")]
        public bool UpdatePost(PuppyPost pPost)
        {
            return _puppyService.UpdatePost(pPost);
        }

        [HttpDelete("{id}")]
        public bool DeletePost(int id)
        {
            return _puppyService.DeletePost(id);
        }

    }
}