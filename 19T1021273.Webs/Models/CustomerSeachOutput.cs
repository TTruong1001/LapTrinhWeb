using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021273.DomainModels;

namespace _19T1021273.Webs.Models
{
    /// <summary>
    /// Kết quả tìm kiếm khách hàng dưới dạng phân trang
    /// </summary>
    public class CustomerSearchOutput : PaginationSearchOutput
    {
        /// <summary>
        /// Danh sách khách hàng
        /// </summary>
        public List<Customer> Data { get; set; }
    }
}