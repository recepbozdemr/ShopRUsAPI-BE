﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRUs.Data.Concrate
{
    public class ErrorModel
    {
        public int StatusCode { get; set; }
        
        public string Message { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
