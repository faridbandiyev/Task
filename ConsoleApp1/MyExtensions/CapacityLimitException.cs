﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTask.MyExtensions
{
    public class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message) { }

    }
}
