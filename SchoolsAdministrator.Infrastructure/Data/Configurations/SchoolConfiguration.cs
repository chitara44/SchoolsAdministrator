
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolsAdministrator.Core.Entities;

public class SchoolConfiguration : IEntityTypeConfiguration<School>
{
    public void Configure(EntityTypeBuilder<School> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .UseIdentityColumn();

        builder
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(255);

        builder
            .Property(x => x.Address)
            .IsRequired()
            .HasMaxLength(255);

        builder
            .ToTable("Schools");
    }
}