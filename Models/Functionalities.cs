using System.ComponentModel.DataAnnotations;

namespace diego_aranda_api.Models
{
    public class Functionalities
    {
              
        [Key]
        public int FUnctionalityId { get; set; }
        public string Label { get; set; }
        public ICollection<Roles> Roles { get; set; }

    }
}