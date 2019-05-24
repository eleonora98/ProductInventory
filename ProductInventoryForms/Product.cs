using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryForms
{
    abstract class Product
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public abstract string Information { get; }

    }
   
}
