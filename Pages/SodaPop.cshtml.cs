using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portifolio.Data;
using Portifolio.Methods;
using Portifolio.Models;

namespace Portifolio.Pages
{
    public class SodaPopModel : PageModel
    {
        public Projects Project {  get; set; }
        public GeneralImages ImageMain { get; set; }
        public List<GeneralImages> AllImages { get; set; } = new List<GeneralImages>();
        public List<Tools> AllTools { get; set; } = new List<Tools>();
        public async Task OnGet([FromServices] ApplicationDbContext Context)
        {
            Project = await ProjectMethods.GetProjectbyid(1, Context);
            ImageMain = Project.Images.FirstOrDefault(x => x.Name.Contains("main"));
            AllImages = Project.Images.ToList();
            AllTools = Project.Tools.ToList();
        }
    }
}
