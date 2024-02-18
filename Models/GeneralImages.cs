using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portifolio.Models
{
    [Table("General_Images")]
    public class GeneralImages
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public Projects Projects { get; set; }


    }
}
