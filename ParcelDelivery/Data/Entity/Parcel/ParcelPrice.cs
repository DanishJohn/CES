using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.Models.Parcel
{
    public class ParcelPrice
    {
        /// <summary>
        /// For hydrating Entity framework model
        /// </summary>
        private ParcelPrice()
        {

        }
        public int Id { get; set; }
        public ParcelSize Size { get; set; }
        public ParcelWeight Weight { get; set; }
        public float Price { get; set; }
    }
}
