using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.EmployerSearch
{
    public class PagedCriteria
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int MaxRows { get; set; }
    }
}
