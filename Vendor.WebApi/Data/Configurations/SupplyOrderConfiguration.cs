using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Core.Models;
using System;

namespace Shop.Core.Data.Configurations
{
    public class SupplyOrderConfiguration : IEntityTypeConfiguration<SupplyOrder>
    {
        public void Configure(EntityTypeBuilder<SupplyOrder> builder)
        {
            builder.HasOne(x => x.Supplier)
                .WithMany(x => x.SupplyOrders)
                .HasForeignKey(x => x.SupplierId);

            builder.HasOne(x => x.Shop)
                .WithMany(x => x.SupplyOrders)
                .HasForeignKey(x => x.ShopId);

            builder.HasOne(x => x.Warehouse)
                .WithMany(x => x.SupplyOrders)
                .HasForeignKey(x => x.WarehouseId);

        }
    }
}