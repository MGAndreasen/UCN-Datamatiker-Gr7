﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.service
{
    interface IOrderLine
    {
        int GetOrderId();

        void AddProduct();

        double getPrice();




    }
}