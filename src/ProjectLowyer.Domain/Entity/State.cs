using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLowyer.Domain.Entity.Base;

namespace ProjectLowyer.Domain.Entity
{
    public class State : EntityBase
    {
        public string? Name { get; set; }

        public string? Uf { get; set; }

        public string? StateCode {  get; set; }


    }
}
