﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsApi
{
    public class CityApi : ApiBaseType
    {
        public string Title { get; set; }
        public int? UtcAdd { get; set; }

        public IEnumerable<AirportApi> Airports { get; set; }
    }
}
