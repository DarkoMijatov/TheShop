using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Core.Data.Configurations
{
    public class SupplyOrderArticleConfiguration : IEntityTypeConfiguration<SupplyOrderArticle>
    {
        public void Configure(EntityTypeBuilder<SupplyOrderArticle> builder)
        {
            builder.HasOne(x => x.SupplyOrder)
                .WithMany(x => x.SupplyOrderArticles)
                .HasForeignKey(x => x.SupplyOrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Article)
                .WithMany(x => x.SupplyOrderArticles)
                .HasForeignKey(x => x.ArticleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}