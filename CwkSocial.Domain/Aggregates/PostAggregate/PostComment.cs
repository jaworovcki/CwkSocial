namespace CwkSocial.Domain.Aggregates.PostAggregate;
public class PostComment
{
    private PostComment() {}

    public Guid CommentId { get; private set; }
    public Guid PostId { get; private set; }
    public Guid UserProfileId { get; private set; }

    public string TextContent { get; private set; }

    public DateTime DateCreated { get; private set; }
    public DateTime LastModified { get; private set; }

    public static PostComment CreatePostComment(Guid postId, Guid userProfileId, string textContent)
    {
        var postComment = new PostComment
        {
            CommentId = postId,
            UserProfileId = userProfileId,
            TextContent = textContent,
            DateCreated = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };

        return postComment;
    }

    public void UpdateCommentText(string newText)
    {
        TextContent = newText;
        LastModified = DateTime.UtcNow;
    }
}