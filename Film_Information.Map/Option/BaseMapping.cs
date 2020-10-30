using Film_Information.Entities.ORM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Map.Option
{
    public class BaseMapping<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(i => i.ID);
            builder.Property(i => i.AddDate).HasColumnName("AddDate").IsRequired();
            builder.Property(i => i.UpdateDate).HasColumnName("UpdateDate").IsRequired(false);
            builder.Property(i => i.DeleteDate).HasColumnName("DeleteDate").IsRequired(false);
            builder.Property(i => i.Status).HasColumnName("Status").IsRequired();
        }
    }
}
