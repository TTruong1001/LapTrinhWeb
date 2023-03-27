using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021273.DomainModels;

namespace _19T1021273.Webs.Models
{
    public class ProductSearchOutput : PaginationSearchOutput
    {
        /// <summary>
        /// 
        /// </summary>
        public int SupplierID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CategoryID { get; set; }

        public List<Product> Data { get; set; }
    }
}