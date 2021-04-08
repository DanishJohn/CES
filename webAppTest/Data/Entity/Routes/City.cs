using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppTest.Data.Entity.Routes
{
    public class City
    {
        private City()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }
    }
}
