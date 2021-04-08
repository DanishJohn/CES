using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.DataContracts.Parcel
{
	public class ParcelCategoryDTO
	{
        private ParcelCategoryDTO()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSupported { get; set; }
        public float ExtraCharge { get; set; }
    }
}
