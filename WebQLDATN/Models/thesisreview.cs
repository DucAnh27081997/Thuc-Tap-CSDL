using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDATN.Models
{
    //    Tên bảng: thesisreview
    //Mô tả: Thông tin về phản biện đồ án tốt nghiệp

    public class thesisreview
    {
        string studentcode { get; set; }        //Mã sinh viên
        string reviewer { get; set; }     // Mã giáo viên
        string defendperiodcode { get; set; }   // Mã đợt bảo vệ
        float reviewermark { get; set; }    // Điểm phản biện

        public thesisreview()
        {
            this.studentcode = "";
            this.reviewer = "";
            this.defendperiodcode = "";
            this.reviewermark = 0;
        }
        /// <summary>
        /// ham khoi tao co tham so Thông tin về phản biện đồ án tốt nghiệp
        /// </summary>
        /// <param name="_studentcode">Mã sinh viên</param>
        /// <param name="_reviewer">Mã giáo viên</param>
        /// <param name="_defendperiodcode">Mã đợt bảo vệ</param>
        /// <param name="reviewermark">Điểm phản biện</param>
        public thesisreview(string _studentcode,string _reviewer, string _defendperiodcode,string reviewermark)
        {
            this.studentcode = "";
            this.reviewer = "";
            this.defendperiodcode = "";
            this.reviewermark = 0;
        }
    }
}