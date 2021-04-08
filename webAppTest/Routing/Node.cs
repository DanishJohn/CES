using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.Entity.Routes;

namespace ParcelDelivery.Routing
{
    public class Node
    {

        public City source { get; set; }
        public City destination { get; set; }

        public Node(City source, City destination)
        {
            this.source = source;
            this.destination = destination;
        }
    }
}
