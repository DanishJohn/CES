using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.Models.Auth;

namespace webAppTest.Data.Models
{
    public class Role
    {
        private Role()
        {

        }
        public string Id { get; set; }
        public string Name { get; set; }
        public IList<User> User { get; set; }
    }
}
