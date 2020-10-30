using Film_Information.Entities.ORM.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Entities.ORM.Entities.Abstract
{
    public interface ICore
    {
        int ID { get; set; }
        DateTime AddDate { get; set; }
        DateTime? DeleteDate { get; set; }
        DateTime? UpdateDate { get; set; }
        Status Status { get; set; }

    }
}
