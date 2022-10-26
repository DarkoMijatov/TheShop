using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Core.Models;

namespace Shop.Core.Data.Configurations
{
    public class BuyerConfiguration : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
            builder.HasMany(x => x.Shoppings)
                .WithOne(x => x.Buyer)
                .HasForeignKey(x => x.BuyerId);
        }
    }
}