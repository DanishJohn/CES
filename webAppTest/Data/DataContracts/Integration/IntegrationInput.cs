using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.DataContracts.Integration
{
    public class IntegrationInput
    {
        public float Weight { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Breadth { get; set; }
        public string Category { get; set; }
    }
}
