using System.ComponentModel.DataAnnotations;

namespace diego_aranda_api.Models
{
    public class Users
    {        
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Roles Roles { get; set; }

    }
}