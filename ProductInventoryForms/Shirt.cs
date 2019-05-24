using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryForms
{
    class Shirt : Product
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public override string Information
        {
            get
            {
                return string.Format("{0}: {1}, {3}, Size:{4} - {2}lv", Title, Description, Price, Color, Size);

            }

        }

    }
}
