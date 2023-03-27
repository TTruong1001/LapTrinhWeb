using _19T1021273.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19T1021273.Webs.Models
{
    public class EmployeeSearchOutput : PaginationSearchOutput
    {
        /// <summary>
        /// Danh sách nhân viên
        /// </summary>
        public List<Employee> Data { get; set; }
    }
}