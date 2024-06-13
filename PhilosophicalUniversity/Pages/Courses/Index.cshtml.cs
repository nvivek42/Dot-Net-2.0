using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PhilosophicalUniversity.Data;
using PhilosophicalUniversity.Models;

namespace PhilosophicalUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly PhilosophicalUniversity.Data.SchoolContext _context;

        public IndexModel(PhilosophicalUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}
