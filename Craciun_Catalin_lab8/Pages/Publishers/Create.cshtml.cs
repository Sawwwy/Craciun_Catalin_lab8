using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Craciun_Catalin_lab8.Data;
using Craciun_Catalin_lab8.Models;

namespace Craciun_Catalin_lab8.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Craciun_Catalin_lab8.Data.Craciun_Catalin_lab8Context _context;

        public CreateModel(Craciun_Catalin_lab8.Data.Craciun_Catalin_lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
