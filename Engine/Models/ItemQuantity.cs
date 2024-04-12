﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuantity
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }

        public ItemQuantity(int ItemID, int quantity)
        {
            ItemID = ItemID;
            Quantity = quantity;
        }
    }
}
