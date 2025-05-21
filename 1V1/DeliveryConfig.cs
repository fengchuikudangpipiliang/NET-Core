

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1V1
{
    public class DeliveryConfig : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("T_Deliverys");
            builder.HasOne<Order>(e => e.Order).WithOne(e => e.Delivery).HasForeignKey<Delivery>(e=>e.OrderId);
        }
    }
}
