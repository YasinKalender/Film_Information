using Film_Information.Entities.ORM.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Map.Option
{
    public class CategoryMapping:BaseMapping<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(i => i.CategoryName).IsRequired().HasMaxLength(200);
            builder.Property(i => i.CategoryDetails).IsRequired().HasMaxLength(300);

            builder.HasMany(i => i.Films)
                .WithOne(i => i.Category)
                .HasForeignKey(i => i.CategoryID)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            base.Configure(builder);
        }


    }
}
