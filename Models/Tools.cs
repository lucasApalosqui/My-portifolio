using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portifolio.Models
{
    public class Tools
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Projects> Projects { get; set; }
    }
}
