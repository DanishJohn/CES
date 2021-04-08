using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppTest.Data.DataContracts.Parcel
{
	public class ParcelSizeDTO
    {
        private ParcelSizeDTO() { }

        public int Id { get; set; }
        public float Depth { get; set; }
        public float Breadth { get; set; }
        public float Height { get; set; }
    }
}
