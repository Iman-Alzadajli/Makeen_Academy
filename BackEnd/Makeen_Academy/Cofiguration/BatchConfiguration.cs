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
    public class BatchConfiguration : IEntityTypeConfiguration<Batch>
    {
        
        void IEntityTypeConfiguration<Batch>.Configure(EntityTypeBuilder<Batch> builder)
        {
            builder.ToTable("Batch");
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Start_Date)
               .IsRequired()
               .HasColumnType("datetime");


            builder.Property(b => b.End_Date)
                   .IsRequired()
                   .HasColumnType("datetime");

            //relation
            builder.HasOne(c => c.courses)
               .WithMany(b => b.batches)
               .HasForeignKey(c => c.CourseId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<Customer>()
                   .WithMany()
                   .UsingEntity(j=>j
                   .ToTable("Enroll"));


        }
    }
}
