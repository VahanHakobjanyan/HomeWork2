﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal interface IBorrowable
    {
        void Borrow();
        void Return();
        bool IsInStock();
    }
}
