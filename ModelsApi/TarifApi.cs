﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsApi
{
    public class TarifApi
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<AddExpenseTypeApi> AddExpenseTypes { get; set; }
    }
}
