using ParcelDelivery.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.DataContracts.Enums
{
    public enum SizeEnum
    {
        [StringValue("Less than 25 cm")]
        LessThan25 = 20,
        [StringValue("Between 25 cm and 40 cm")]
        Between25And40 = 40,
        [StringValue("More than 40 cm")]
        MoreThan40 = 80,
    }
}
