﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalAppPROGPOE
{
    public class AVLNode
    {
        public ServiceRequest Data { get; set; }
        public AVLNode Left { get; set; }
        public AVLNode Right { get; set; }
        public int Height { get; set; }

        public AVLNode(ServiceRequest data)
        {
            Data = data;
            Left = null;
            Right = null;
            Height = 1;
        }
    }
}
