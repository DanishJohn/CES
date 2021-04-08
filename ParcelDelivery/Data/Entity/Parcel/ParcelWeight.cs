using ParcelDelivery.Data.DataContracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.Models.Parcel
{
    public class ParcelWeight
    {
        private ParcelWeight()
        {

        }

        public int Id { get; set; }
        public WeightEnum Weight { get; set; }
        public bool IsSupported { get; set; }
    }
}
