using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetCoreAuth.Data;
using DotNetCoreAuth.Entities;

namespace DotNetCoreAuth.Pages.Restaurantes
{
    public class DeleteModel : PageModel
    {
        private readonly DotNetCoreAuth.Data.ApplicationDbContext _context;

        public DeleteModel(DotNetCoreAuth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Restaurante Restaurante { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurante = await _context.Restaurantes.FirstOrDefaultAsync(m => m.Id == id);

            if (Restaurante == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurante = await _context.Restaurantes.FindAsync(id);

            if (Restaurante != null)
            {
                _context.Restaurantes.Remove(Restaurante);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
