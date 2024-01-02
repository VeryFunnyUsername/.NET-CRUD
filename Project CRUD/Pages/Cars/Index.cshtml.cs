using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_CRUD.Data;
using Project_CRUD.Models;

namespace Project_CRUD.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly Project_CRUD.Data.Project_CRUDContext _context;

        public IndexModel(Project_CRUD.Data.Project_CRUDContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
