﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdule13_OOP
{
    public class MyExcaption: Exception
    {
        
        public int Code { get; set; } 
        public MyExcaption (int Code)
        {
            this.Code= Code;
        }
        
    }
}
