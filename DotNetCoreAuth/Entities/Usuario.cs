using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreAuth.Entities
{
    public class Usuario : IdentityUser
    {
        [PersonalData]
        public DateTime? DataDeInclusao { get; set; }

        public string NomeCompleto { get; set; }
    }
}
