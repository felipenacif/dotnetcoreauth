using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DotNetCoreAuth.Entities
{
    public class UsuarioClaimsPrincipalFactory : UserClaimsPrincipalFactory<Usuario, IdentityRole>
    {
        public UsuarioClaimsPrincipalFactory(UserManager<Usuario> userManager,
                                             RoleManager<IdentityRole> roleManager,
                                             IOptions<IdentityOptions> options
            ) : base(userManager, roleManager, options)
        {

        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(Usuario user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("DataDeInclusao", user.DataDeInclusao.Value.ToShortDateString()));
            identity.AddClaim(new Claim("NomeCompleto", user.NomeCompleto));

            return identity;
        }
    }
}
