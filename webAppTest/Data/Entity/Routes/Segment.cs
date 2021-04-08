using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppTest.Data.Entity.Routes
{
    public class Segment
    {
        /// <summary>
        /// For hydrating Entity Framework model
        /// </summary>
        private Segment()
        {

        }
        public int Id { get; set; }
        public City From { get; set; }
        public City To { get; set; }
        public float Duration { get; set; }
        public bool IsActive { get; set; }
    }
}
