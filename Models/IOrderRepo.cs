﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Models
{
    public interface IOrderRepo
    {
        void CreateOrder(Order order);
    }
}