using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppTest.Data.Models.Parcel
{
    public class ParcelCategory
    {
        private ParcelCategory()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSupported { get; set; }
        public float ExtraCharge { get; set; }
    }
}
