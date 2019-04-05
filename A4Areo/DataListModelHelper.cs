using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4Areo
{
    public class DataListModelHelper<T> where T : class
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<T> data { get; set; }
    }
}
