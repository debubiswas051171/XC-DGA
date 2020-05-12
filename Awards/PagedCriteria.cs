using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.Awards
{
    public class PagedCriteria
    {
        /// <summary>
        /// Index of page 
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Number of elements in each page
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Number of total elements so that paging can be implemented in client side.
        /// </summary>
        public int MaxRows { get; internal set; }

    }
}
