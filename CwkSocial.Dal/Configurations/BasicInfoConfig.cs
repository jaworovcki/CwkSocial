using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Dal.Configurations;
public class BasicInfoConfig : IEntityTypeConfiguration<BasicInfo>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<BasicInfo> builder)
    {
        
    }
}