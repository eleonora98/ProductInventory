﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryForms
{
    class Pants : Product
    {
        public string Color { get; set; }

        public override string Information
        {
            get
            {
                return string.Format("{0}: {1}, {3} - {2}lv", Title, Description, Price, Color);

            }
        }


    }
}
