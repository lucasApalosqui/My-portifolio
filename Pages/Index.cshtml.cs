using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Portifolio.Data;
using Portifolio.Models;

namespace Portifolio.Pages
{
    public class IndexModel : PageModel
    {


        public List<Projects> projectsL {  get; set; } = new List<Projects>();
        public async Task OnGet([FromServices] ApplicationDbContext Context)
        {
            projectsL = await Context.
                Projects
                .AsNoTracking()
                .Include(x => x.Images)
                .Include(x => x.Tools)
                .ToListAsync();

        }
    }

}
