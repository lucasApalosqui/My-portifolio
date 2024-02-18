using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portifolio.Data;
using Portifolio.Models;

namespace Portifolio.Methods
{
    public static class ProjectMethods
    {
        public static async Task<Projects> GetProjectbyid(int id, [FromServices] ApplicationDbContext Context)
        {
            Projects projectN = await Context.Projects
                .AsNoTracking()
                .Include(x => x.Images)
                .Include(x => x.Tools)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (projectN == null)
            {
                return null;
            } else
            {
                return projectN;
            }
        }
    }
}
