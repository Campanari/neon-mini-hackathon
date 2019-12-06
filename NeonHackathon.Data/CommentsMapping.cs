using Microsoft.EntityFrameworkCore;
using NeonHackathon.Domain.Entities;

namespace NeonHackathon.Data
{
    public class CommentsMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure()
        {
        }
    }
}