using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Products_RazorPages.Models;

namespace Products_RazorPages.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Products_RazorPages.Models.ShopContext _context;

        public IndexModel(Products_RazorPages.Models.ShopContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                User = await _context.Users.ToListAsync();
            }
        }
    }
}
