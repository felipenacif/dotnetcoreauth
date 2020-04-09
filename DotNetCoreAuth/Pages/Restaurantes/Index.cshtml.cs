using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetCoreAuth.Data;
using DotNetCoreAuth.Entities;
using Microsoft.AspNetCore.Authorization;

namespace DotNetCoreAuth.Pages.Restaurantes
{
    [Authorize(Policy = "PodeIncluirRestaurantes")]
    public class IndexModel : PageModel
    {
        private readonly DotNetCoreAuth.Data.ApplicationDbContext _context;

        public IndexModel(DotNetCoreAuth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Restaurante> Restaurante { get;set; }

        public async Task OnGetAsync()
        {
            Restaurante = await _context.Restaurantes.ToListAsync();
        }
    }
}
