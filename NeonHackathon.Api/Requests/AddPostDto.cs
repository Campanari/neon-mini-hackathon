namespace NeonHackthon.Api.Requests
{
    public class AddPostDto
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}