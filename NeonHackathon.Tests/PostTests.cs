using NUnit.Framework;

namespace NeonHackthon.Tests
{
    public class PostTests
    {
        [Test]
        public void ShouldCreateBlogPost()
        {
            var dto = new AddPostDto
            {
                UserId = 1,
                Title = "Title",
                Body = "Body"
            };

        }

        [Test]
        public void ShouldThrowsExceptionWhenCreateBlogWithInvalidUser()
        {
            var dto = new AddPostDto
            {
                UserId = -1,
                Title = "Title",
                Body = "Body"
            };

        }

        [Test]
        public void ShouldThrowsExceptionWhenCreateBlogWithNoContent()
        {
            var dto = new AddPostDto
            {
                UserId = 1,
                Title = "Title",
                Body = ""
            };

        }

        [Test]
        public void ShouldThrowsExceptionWhenCreateBlogWithNoTitle()
        {
            var dto = new AddPostDto
            {
                UserId = 1,
                Title = "",
                Body = "Body"
            };

        }

        [Test]
        public void ShouldWriteCommentToPost()
        {

        }

        [Test]
        public void ShouldThrowsExceptionWhenWriteCommentToPostWithEmptyComment()
        {
            
        }

        [Test]
        public void ShouldAddTagToPost()
        {
            
        }
        
        [Test]
        public void ShouldThrowsExceptionWhenAddTagToPostWithEmptyTag()
        {
            
        }

        [Test]
        public void ShouldSearchPostsByTag()
        {

        }

        [Test]
        public void ShouldSearchPostsByAuthor()
        {

        }

        [Test]
        public void ShouldSearchPostsByTitle()
        {

        }
    }
}