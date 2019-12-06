using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NeonHackathon.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            throw new NotImplementedException("Implement me!");
        }

        [HttpGet]
        [Route("/{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            throw new NotImplementedException("Implement me!");
        }

        [HttpGet]
        [Route("/user/{userId}")]
        public async Task<IActionResult> GetAllByUserId( int userId)
        {
            throw new NotImplementedException("Implement me!");
        }
        
        [HttpGet]
        [Route("/post/{postId}")]
        public async Task<IActionResult> GetAllByPostId([FromQuery] int postId)
        {
            throw new NotImplementedException("Implement me!");
        }

        [HttpPost]
        public async Task<IActionResult> Post(int id)
        {
            throw new NotImplementedException("Implement me!");
        }

        [HttpDelete]
        [Route("/{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            throw new NotImplementedException("Implement me!");
        }
    }
}