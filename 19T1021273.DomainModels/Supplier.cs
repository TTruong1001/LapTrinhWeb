using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19T1021273.DomainModels
{

    /// <summary>
    /// định nghĩa các phép sử lý dữ liệu trên nhà cung cấp
    /// sử dụng cách nàu dẫn đến việt lập đi lập lại các kiểu code giống nhau
    /// cho các đối tượng dữ liệu tương tự 
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// 
        /// </summary>
        public int SupplierID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ContactName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }
        ///
        public string Phone { get; set; }



    }
}
