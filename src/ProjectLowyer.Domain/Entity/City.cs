using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLowyer.Domain.Entity.Base;

namespace ProjectLowyer.Domain.Entity
{
    public class City : EntityBase
    {
        public string? Name { get; set; }

        public string CityCode {  get; set; } = string.Empty;

        public long StateId {  get; set; }

        public virtual State? State { get; set; }
    }
}
