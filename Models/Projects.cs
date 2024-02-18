using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portifolio.Models
{
    [Table("projects")]
    public class Projects
    {
        public Projects(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string LinkRepository { get; set; }

        public string PageName { get; set; }

        public IList<GeneralImages> Images { get; set; }

        public IList<Tools> Tools { get; set; }

        






    }
}
