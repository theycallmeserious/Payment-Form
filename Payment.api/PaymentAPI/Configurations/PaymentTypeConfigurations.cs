using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentAPI.Models;

namespace PaymentAPI.Configurations
{
    public class PaymentTypeConfigurations : IEntityTypeConfiguration<PaymentDetail>
    {
        public void Configure(EntityTypeBuilder<PaymentDetail> builder)
        {
            builder.Property(n => n.CardOwnerName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.CardNumber).HasMaxLength(16).IsRequired();
            builder.Property(s => s.SecurityCode).HasMaxLength(3).IsRequired();
            builder.Property(d => d.ExpirationDate).HasMaxLength(5).IsRequired();

            builder.HasKey(pk => pk.PaymentDetailId)
                .HasName("PaymentDetailId_PK");
        }
    }
}
