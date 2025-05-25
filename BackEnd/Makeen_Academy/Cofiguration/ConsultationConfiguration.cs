using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Makeen_Academy.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Makeen_Academy.Cofiguration
{
    public class ConsultationConfiguration : IEntityTypeConfiguration<Consultation>
    {
        void IEntityTypeConfiguration<Consultation>.Configure(EntityTypeBuilder<Consultation> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();
            builder.Property(c => c.Date)
                .IsRequired();
            builder.Property(c => c.Topic)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(c => c.Trainer)
             .WithMany(c => c.ConsultationList)
             .HasForeignKey(c => c.TrainerId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Customer)
             .WithMany(c => c.ConsultationList)
             .HasForeignKey(c => c.CustomerId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
