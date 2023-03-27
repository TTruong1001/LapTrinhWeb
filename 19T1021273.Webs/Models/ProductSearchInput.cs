using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19T1021273.Webs.Models
{
    public class ProductSearchInput : PaginationSearchInput
 
    {
        /// <summary>
        /// 
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SearchValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int categoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int supplierID { get; set; }

    }
}