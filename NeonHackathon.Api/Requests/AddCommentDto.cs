namespace NeonHackthon.Api.Requests
{
    public class AddCommentDto
    {
        public string UserId { get; set; }
        public int PostId { get; set; }
        public string Comment { get; set; }
    }
}