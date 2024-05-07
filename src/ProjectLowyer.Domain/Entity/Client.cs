using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLowyer.Domain.Entity.Base;
using ProjectLowyer.Domain.Enum;

namespace ProjectLowyer.Domain.Entity.Base
{
    public class Client : EntityBase
  

    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? Cpf_Cnpj { get; set; }

        public string? Rg_Ie { get; set; }
       
        public string? Notes { get; set; }

        public TypePerson TypePerson { get; set; }

    }

}
