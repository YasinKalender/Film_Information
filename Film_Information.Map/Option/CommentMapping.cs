using Film_Information.Entities.ORM.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Map.Option
{
    public class CommentMapping:BaseMapping<Comments>
    {
        public override void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.Property(i => i.FirstName).IsRequired();
            builder.Property(i => i.LastName).IsRequired();
            builder.Property(i => i.Email).IsRequired();
            


            base.Configure(builder);
        }

    }
}
