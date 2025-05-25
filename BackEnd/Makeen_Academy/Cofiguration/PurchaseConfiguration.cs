using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Makeen_Academy.Models;

namespace Makeen_Academy.Cofiguration
{
    internal class PurchaseConfiguration: IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
            builder.Property(p => p.Quantity)
                .IsRequired();
            builder.Property(p => p.DeliveryLocation)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(p => p.Book)
             .WithMany(p => p.Purchases)
             .HasForeignKey(p => p.BookId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Customer)
             .WithMany(p => p.PurchaseList)
             .HasForeignKey(p => p.CustomerId)
             .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
