using Film_Information.Entities.ORM.Entities.Abstract;
using Film_Information.Entities.ORM.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Entities.ORM.Entities.Concrete
{
    public class BaseEntity : ICore
    {
        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
    }
}
