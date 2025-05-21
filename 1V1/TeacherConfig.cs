

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1V1
{
    public class TeacherConfig : IEntityTypeConfiguration<Teachers>
    {
        public void Configure(EntityTypeBuilder<Teachers> builder)
        {
            builder.ToTable("T_Teachers");
            builder.HasMany<Student>(e=>e.Students).WithMany(e=>e.Teachers).UsingEntity(t=> 
            { 
                t.ToTable("T_Teachers_Students"); 
            }
            );
        }
    }
}
