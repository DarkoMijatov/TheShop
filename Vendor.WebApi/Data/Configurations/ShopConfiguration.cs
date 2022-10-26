using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Shop.Core.Data.Configurations
{
    public class ShopConfiguration : IEntityTypeConfiguration<Models.Shop>
    {
        public void Configure(EntityTypeBuilder<Models.Shop> builder)
        {
            builder.HasOne(x => x.Warehouse)
                .WithMany(x => x.Shops)
                .HasForeignKey(x => x.WarehouseId);
        }
    }
}