using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Core.Models;

namespace Shop.Core.Data.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasOne(x => x.Shop)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.ShopId);

            builder.HasOne(x => x.Warehouse)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.WarehouseId);

            builder.HasOne(x => x.Supplier)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.SupplierId);
        }
    }
}