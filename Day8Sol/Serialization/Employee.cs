﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{

    [Serializable ]
    class Employee
    {

        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
    }
}
