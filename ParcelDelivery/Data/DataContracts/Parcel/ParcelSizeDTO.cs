using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Data.DataContracts.Parcel
{
	public class ParcelSizeDTO
    {
        public ParcelSizeDTO() { }

        public ParcelSizeDTO(ParcelSize parcelSize)
        {
            Depth = parcelSize.Depth;
            Breadth = parcelSize.Breadth;
            Height = parcelSize.Height;
        }

        public int Id { get; set; }
        public float Depth { get; set; }
        public float Breadth { get; set; }
        public float Height { get; set; }
    }
}
