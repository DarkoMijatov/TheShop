using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Core.Models;

namespace Shop.Core.Data.Configurations
{
    public class ShoppingArticleConfiguration : IEntityTypeConfiguration<ShoppingArticle>
    {
        public void Configure(EntityTypeBuilder<ShoppingArticle> builder)
        {
            builder.HasOne(x => x.Shopping)
                .WithMany(x => x.ShoppingArticles)
                .HasForeignKey(x => x.ShoppingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Article)
                .WithMany(x => x.ShoppingArticles)
                .HasForeignKey(x => x.ArticleId);
        }
    }
}