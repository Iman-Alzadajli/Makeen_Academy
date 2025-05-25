using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Makeen_Academy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Makeen_Academy.Cofiguration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        void IEntityTypeConfiguration<Course>.Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                    .ValueGeneratedOnAdd()
                    .IsRequired();

            builder.Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(50);

            //relations
            //builder.HasMany(c => c.batches)  
            //   .WithOne(b => b.courses) 
            //   .HasForeignKey(b => b.CourseId)  
            //   .OnDelete(DeleteBehavior.Cascade);




        }
    }
}
