using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDATN.Models
{
    public class thesis
    {
        //        Tên bảng: thesis
        //Mô tả: Thông tin về giao nhận đồ án tốt nghiệp

        public string studentcode { get; set; }      //  Mã sinh viên
        public string projectcode { get; set; }      // Mã đề tài
        public float supervisormark { get; set; }      // Điểm hướng dẫn
        /// <summary>
        /// Hàm khởi tạo nhập đồ án tốt nghiệp
        /// </summary>
        public thesis()
        {
            this.studentcode = "";
            this.projectcode = "";
            this.supervisormark = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_studentcode"> Mã sinh viên</param>
        /// <param name="_projectcode">Mã đề tài</param>
        /// <param name="_supervisormark">Điểm hướng dẫn</param>
        public thesis(string _studentcode,string _projectcode, float _supervisormark)
        {
            this.studentcode = "";
            this.projectcode = "";
            this.supervisormark = 0;
        }

    }
}