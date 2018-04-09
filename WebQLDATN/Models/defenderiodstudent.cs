using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDATN.Models
{
    /// <summary>
    /// lớp Thông tin về các sinh viên đăng ký làm đồ án tốt nghiệp
    /// </summary>
    public class defenderiodstudent
    {
        string studentcode { get; set; } //đề tài, khóa chính
        string defendperiodcode { get; set; }// Mã đợt bảo vệ
        bool valid { get; set; }//Đủ tiêu chuẩn làm đồ án(true) hay không(false)

        /// <summary>
        /// Ham khoi tao ko co tham so
        /// </summary>
        public defenderiodstudent()
        {
            this.studentcode = "";
            this.defendperiodcode = "";
            this.valid = true;

        }

        /// <summary>
        /// Ham khoi tao co tham so 
        /// Thông tin về các sinh viên đăng ký làm đồ án tốt nghiệp
        /// </summary>
        /// <param name="studentcode">Mã đề tài, khóa chính</param>
        /// <param name="defendperiodc">Mã đợt bảo vệ</param>
        /// <param name="valid">Đủ tiêu chuẩn làm đồ án(true) hay không(false)</param>
        public defenderiodstudent(string _studentcode, string _defendperiodc, bool _valid)
        {
            this.studentcode = _studentcode;
            this.defendperiodcode = _defendperiodc;
            this.valid = _valid;
        }
    }
}