using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLowyer.Domain.Enum
{
    public enum TypePerson
    {
        [Description("--- Selecione ---")]
        selected,
        [Description("Pessoa Fisica")]
        Active,
        [Description("Pessoa Juridica")]
        Inactive
    }
}