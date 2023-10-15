using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Common
{
    public abstract class EntityBase
    {
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdateDate { get; set; }

    }
}
