using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLowyer.Domain.Enum
{
    public enum Situation
    {
        [Description("--- Selecione ---")]
        selected,
        [Description("Ativo")]
        Active,
        [Description("Inativo")]
        Inactive,
        [Description("Deletado")]
        Deleted
    }
}
