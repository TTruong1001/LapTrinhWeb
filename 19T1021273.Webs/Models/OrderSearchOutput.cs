using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021273.DomainModels;
using _19T1021273.Webs.Models;

namespace _19T1021273.Webs.Models
{
    public class OrderSearchOutput : PaginationSearchOutput
    {
        public List<Order> Data { get; set; }
        public int Status { get; set; }
    }
}