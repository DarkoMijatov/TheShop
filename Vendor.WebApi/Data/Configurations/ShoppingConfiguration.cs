using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Core.Models;

namespace Shop.Core.Data.Configurations
{
    public class ShoppingConfiguration : IEntityTypeConfiguration<Shopping>
    {
        public void Configure(EntityTypeBuilder<Shopping> builder)
        {
            builder.HasOne(x => x.Buyer)
                .WithMany(x => x.Shoppings)
                .HasForeignKey(x => x.BuyerId);

            builder.HasOne(x => x.Shop)
                .WithMany(x => x.Shoppings)
                .HasForeignKey(x => x.ShopId);
        }
    }
}