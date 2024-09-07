using CwkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CwkSocial.Domain.Aggregates.PostAggregate;
public class Post
{
    private readonly List<PostComment> _comments = new();
    private readonly List<PostInteraction> _interactions = new();   

    private Post() {}

    public Guid PostId { get; private set; }

    public Guid UserProfileId { get; private set; }
    public UserProfile UserProfile { get; private set; }

    public string TextContent { get; private set; }

    public DateTime DateCreated { get; private set; }
    public DateTime LastModified { get; private set; }

    public IEnumerable<PostComment> Comments { get { return _comments; } }
    public IEnumerable<PostInteraction> Interactions { get { return _interactions; } }

    public static Post CreatePost(Guid userProfileId, string textContent)
    {
        var post = new Post
        {
            UserProfileId = userProfileId,
            TextContent = textContent,
            DateCreated = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };

        return post;
    }

    public void UpdatePostText(string newText)
    {
        TextContent = newText;
        LastModified = DateTime.UtcNow;
    }

    public void AddPostComment(PostComment comment)
    {
        _comments.Add(comment);
    }

    public void RemoveComment(PostComment comment)
    {
        _comments.Remove(comment);
    }

    public void AddInteraction(PostInteraction interaction)
    {
        _interactions.Add(interaction);
    }

    public void RemoveInteraction(PostInteraction interaction)
    {
        _interactions.Remove(interaction);
    }
}