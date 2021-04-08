using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppTest.Data.Models.Parcel
{
    public class ParcelSize
    {
        private ParcelSize() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public float Depth { get; set; }
        public float Breadth { get; set; }
        public float Height { get; set; }
    }
}
