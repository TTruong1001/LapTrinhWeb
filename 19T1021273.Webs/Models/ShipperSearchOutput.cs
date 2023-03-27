using _19T1021273.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace _19T1021273.Webs.Models
{
    public class ShipperSearchOutput : PaginationSearchOutput
    {
        /// <summary>
        /// Danh sách người giao hàng
        /// </summary>
        public List<Shipper> Data { get; set; }
    }
}