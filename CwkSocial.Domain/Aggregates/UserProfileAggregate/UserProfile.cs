namespace CwkSocial.Domain.Aggregates.UserProfileAggregate;
public class UserProfile
{
    private UserProfile()
    {
        
    }

    public Guid UserProfileId { get; private set; }   
    public string IdentityId { get; private set; }

    public BasicInfo BasicInfo { get; private set; }

    public DateTime DateCreated { get; private set; }
    public DateTime LastModified { get; private set; }

    public static UserProfile CreateUserProfile(string identityId, BasicInfo basicinfo) 
    {
        var userProfile = new UserProfile
        {
            IdentityId = identityId,
            BasicInfo = basicinfo,
            DateCreated = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };

        return userProfile;
    }

    public void UpdateBasicInfo(BasicInfo basicInfo)
    {
        BasicInfo = basicInfo;
        LastModified = DateTime.UtcNow;
    }
}