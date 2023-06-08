using System;

namespace forms1
{
    internal struct OrderData
    { 
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public string Service { get; set; }
        public string Status { get; set; }
        public TimeSpan ServiceTimespan { get; set; }
        public int Price { get; set; }
    }
}
