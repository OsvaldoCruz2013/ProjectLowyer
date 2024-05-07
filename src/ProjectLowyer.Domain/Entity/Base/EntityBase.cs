using ProjectLowyer.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLowyer.Domain.Entity.Base
{
    public class EntityBase
    {
        public long Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public Situation Situation { get; set; }

        public int CreatedUserId  { get; set; }

        public int? ModifiedUserId {  get; set; }

        public int? DeleteUserId { get; set; }

        public string? Observation { get; set; }
    }
}
