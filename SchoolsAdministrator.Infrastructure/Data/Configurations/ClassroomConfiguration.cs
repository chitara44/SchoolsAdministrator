
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolsAdministrator.Core.Entities;

public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
{
    public void Configure(EntityTypeBuilder<Classroom> builder)
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
            .Property(x => x.Capacity)
            .IsRequired();

        builder
            .HasOne(x => x.School)
            .WithMany(y => y.Classrooms)
            .HasForeignKey(x => x.SchoolId);

        builder
            .ToTable("Classrooms");
    }
}