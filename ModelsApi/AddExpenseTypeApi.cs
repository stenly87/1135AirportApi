using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsApi
{
    public class AddExpenseTypeApi
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal? AddCost { get; set; }
    }
}
