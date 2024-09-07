using CwkSocial.Dal.Configurations;
using CwkSocial.Domain.Aggregates.PostAggregate;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Dal;
public class DataContext : IdentityDbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new PostCommentConfig());
        builder.ApplyConfiguration(new PostInteractionConfig());
        builder.ApplyConfiguration(new UserProfileConfig());
    }

}