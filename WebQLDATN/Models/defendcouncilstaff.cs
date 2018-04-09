using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDATN.Models
{
    //    Tên bảng: defendcouncilstaff
    //Mô tả: Thông tin về việc bổ nhiệm giáo viên vào hội đồng bảo vệ đồ án tốt nghiệp

    public class defendcouncilstaff
    {
        string defendcouncilcode { get; set; } //Mã hội đồng, khóa chính
        string staffcode { get; set; } //Mã giáo viên, khóa chính
        string defendcouncildutycode { get; set; }//   Mã chức vụ

        public defendcouncilstaff()
        {
            this.defendcouncilcode = "";
            this.staffcode = "";
            this.defendcouncildutycode = "";

        }

        /// <summary>
        /// Tạo Thông tin về việc bổ nhiệm giáo viên vào hội đồng bảo vệ đồ án tốt nghiệp
        /// </summary>
        /// <param name="_defendcouncilcode">Mã hội đồng, khóa chính</param>
        /// <param name="_staffcode">Mã giáo viên, khóa chính</param>
        /// <param name="_defendcouncildutycode">//   Mã chức vụ</param>
        public defendcouncilstaff(string _defendcouncilcode,string _staffcode, string _defendcouncildutycode)
        {
            this.defendcouncilcode = "";
            this.staffcode = "";
            this.defendcouncildutycode = "";

        }
    }
}