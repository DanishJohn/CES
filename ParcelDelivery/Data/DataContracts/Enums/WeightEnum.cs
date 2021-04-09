using ParcelDelivery.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.DataContracts.Enums
{
    public enum WeightEnum
    {
        [StringValue("Less than 1 kg")]
        LessThan1 = 0,
        [StringValue("Between 1 and 5 kg")]
        Between1And5 = 3,
        [StringValue("More than 5 kg")]
        MoreThan5 = 8,
    }
}
