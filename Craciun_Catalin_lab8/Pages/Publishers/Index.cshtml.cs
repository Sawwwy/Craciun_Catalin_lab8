using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Craciun_Catalin_lab8.Data;
using Craciun_Catalin_lab8.Models;

namespace Craciun_Catalin_lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Craciun_Catalin_lab8.Data.Craciun_Catalin_lab8Context _context;

        public IndexModel(Craciun_Catalin_lab8.Data.Craciun_Catalin_lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
