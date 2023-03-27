using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19T1021273.DomainModels;

namespace _19T1021273.DataLayers
{
    /// <summary>
    /// Định nghĩa các phép sử lý dữ liệu trên nhà cung cấp 
    /// </summary>
    public interface ICustomerDAL
    {
        /// <summary>
        /// Tìm kiếm và lấy danh sách các nhà cung cấp dưới dạng ph
        /// </summary>
        /// <param name="page">trang cần hiển thị</param>
        /// <param name="pageSize">Số dòng hiển thị trên mỗi trang(0 yêu cầu phân trang </param>
        /// <param name="searchvalue">Tên cần tìm kiếm(chuỗi rỗng nếu không tìm kiếm theo tên)</param>
        /// <returns></returns>
        IList<Customer> list(int page = 1, int pageSize = 0, string searchvalue = "");
        /// <summary>
        /// Đếm số nhà cung cấp
        /// </summary>
        /// <param name="searchValue">Tên cần tìm kiếm (chuỗi rỗng không tìm kiếm theo tên)
        /// <returns></returns>
        int Count(string searchValue = "");
        /// <summary>
        /// Bổ sung thêm nhà cung cấp
        /// </summary>
        /// <param name="data"></param>
        /// <returns>ID của nhà cung cấp tự tạo mới</returns>
        int Add(Customer data);
        /// <summary>
        /// Cập nhật thông tin của nhà cung cấp
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Customer data);
        /// <summary>
        /// Xoá một nhà cung cấp dựa vào mã của nhà cung cấp
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        bool Delete(int customerID);
        /// <summary>
        /// Lấy thông tin của 1 nhà cung cấp dựa vào mã của nhà cung cấp
        /// </summary>
        /// <param name="customerID">mã của nhà cung cấp cần xoá</param>
        /// <returns></returns>
        Supplier Get(int customerID);
        /// <summary>
        /// Kiểm tra xem nhà cung cấp hiện có dữ liệu hay không?
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <returns></returns>
        bool InUsed(int CustomerID);
    }
}
