using Film_Information.Entities.ORM.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Map.Option
{
    public class FilmMapping:BaseMapping<Film>
    {

        public override void Configure(EntityTypeBuilder<Film> builder)
        {

            builder.Property(i => i.FilmName).IsRequired().HasMaxLength(100);
            builder.Property(i => i.FilmDescription).IsRequired().HasMaxLength(5000);
           

            builder.HasOne(i => i.Category)
                .WithMany(i => i.Films)
                .HasForeignKey(i => i.CategoryID)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
                


            base.Configure(builder);
        }

    }
}
