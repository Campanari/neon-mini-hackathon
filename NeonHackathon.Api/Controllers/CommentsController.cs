using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NeonHackathon.Domain.Entities;
using NeonHackathon.Domain.Interfaces;

namespace NeonHackathon.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentsController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comments = await _unitOfWork.Repository<Comment>().GetAllAsync();
            return Ok(comments);
        }

        [HttpGet]
        [Route("/{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            throw new NotImplementedException("Implement me!");
        }

        [HttpGet]
        [Route("/user/{userId}")]
        public async Task<IActionResult> GetAllByUserId(int userId)
        {
            throw new NotImplementedException("Implement me!");
        }
        
        [HttpGet]
        [Route("/post/{postId}")]
        public async Task<IActionResult> GetAllByPostId(int postId)
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