using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TaskAuthenticationAuthorization.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
    public class User
    {    
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
    }

}
