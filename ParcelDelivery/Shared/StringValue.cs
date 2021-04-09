using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Shared
{
    public class StringValue : Attribute
    {
        public string Value { get; set; }
        public StringValue(string value)
        {
            Value = value;
        }
    }
}
