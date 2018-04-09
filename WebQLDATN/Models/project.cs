using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDATN.Models
{
    /*
     Tên bảng: project
Mô tả: Thông tin về các đề tài dùng cho đồ án tốt nghiệp

         */
    public class project
    {
        public string code { get; set; }                // ma de ta khoa chinh  
        public string name { get; set; }                // Ten de tai
        public string detail { get; set; }              // chi tiet ve de tai
        public string departmentcode { get; set; }      // ma chuyen nganh
        public string defendperiodcode { get; set; }    // ma dot bao ve
        public string supervisor { get; set; }          // ma giao vien


        public project()
        {
            this.code = "";
            this.name = "";
            this.detail = "";
            this.departmentcode = "";
            this.defendperiodcode = "";
            this.supervisor = "";
        }
        
        /// <summary>
        /// Hàm tạo Thông tin về các đề tài dùng cho đồ án tốt nghiệp
        /// </summary>
        /// <param name="_code">ma de ta khoa chinh</param>
        /// <param name="_name">Ten de tai</param>
        /// <param name="_detail">chi tiet ve de tai</param>
        /// <param name="_departmentcode">ma chuyen nganh</param>
        /// <param name="_defendperiodcode">ma dot bao ve</param>
        /// <param name="_supervisor"> ma giao vien</param>
        public project(string _code, string _name, string _detail, string _departmentcode, string _defendperiodcode, string _supervisor)
        {
            this.code = "";
            this.name = "";
            this.detail = "";
            this.departmentcode = "";
            this.defendperiodcode = "";
            this.supervisor = "";
        }

    }
}