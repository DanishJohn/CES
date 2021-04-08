using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppTest.Data.Models.Auth
{
    public class User : IdentityUser
    {
        private User()
        {

        }
        public override string Id { get; set; }
        public override string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public Role Role { get; set; }


    }
}
