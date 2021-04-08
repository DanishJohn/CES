using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppTest.Data.Models.Parcel
{
    public class ParcelWeight
    {
        private ParcelWeight()
        {

        }

        public int Id { get; set; }
        public float Weight { get; set; }
    }
}
