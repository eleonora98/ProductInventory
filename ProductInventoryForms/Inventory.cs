using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryForms
{
    internal class Inventory
    {
        public List<Product> Products { get; set; }
        public List<Shirt> Shirts { get; set; }
        public List<Pants> Pants { get; set; }
        public List<Coat> Coats { get; set; }
        public List<Dress> Dresses { get; set; }
        

        public Inventory()
        {
            //Product[] products = new Product[5];
            //products[0] = new Shirt();

            Products = new List<Product>();
            Shirts = new List<Shirt>();
            Pants = new List<Pants>();
            Coats = new List<Coat>();
            Dresses = new List<Dress>();

        }
    }
}
