using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Routing
{
    public class Node
    {
        public int source { get; set; }
        public int destination { get; set; }

        public Node(int source, int destination)
        {
            this.source = source;
            this.destination = destination;
        }
    }
}
