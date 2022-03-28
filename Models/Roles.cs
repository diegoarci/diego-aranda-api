using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace diego_aranda_api.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        public string Label { get; set; }
        public ICollection<Functionalities>Functionalities { get; set; }
        public List<Users> Users { get; set; }
    }       

}