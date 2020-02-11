using System;
using System.Collections.Generic;

namespace TestReverseEf
{
    public partial class Stores
    {
        public Stores()
        {
            Discounts = new HashSet<Discounts>();
            Sales = new HashSet<Sales>();
        }

        public string StorId { get; set; }
        public string StorName { get; set; }
        public string StorAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<Discounts> Discounts { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
