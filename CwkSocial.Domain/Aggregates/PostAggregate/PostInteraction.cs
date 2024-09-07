namespace CwkSocial.Domain.Aggregates.PostAggregate;
public class PostInteraction
{
    private PostInteraction() {}
    public Guid PostInteractionId { get; private set; }
    public Guid PostId { get; private set; }

    public InteractionType InteractionType { get; private set; }

    public static PostInteraction CreatePostInteraction(Guid postId, InteractionType type)
    {
        var postInteraction = new PostInteraction
        {
            PostId = postId,
            InteractionType = type
        };

        return postInteraction;
    }
}