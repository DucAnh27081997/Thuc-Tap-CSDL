using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDATN.Models
{
    /*
     *Tên bảng: defendcouncil
     *Mô tả: Thông tin về các hội đồng bảo vệ đồ án tốt nghiệp
     */
    public class defendcouncil
    {
        string code { get; set; }         // Mã hội đồng, khóa chính
        string codeview { get; set; }   // Mã hội đồng hiển thị
        string name { get; set; }   // Tên hội đồng bảo vệ
        string departmentcode { get; set; }  //     Mã chuyên ngành
        string defendperiodcode { get; set; } //    Mã đợt bảo vệ
        string hallcode { get; set; }    //     Mã giảng đường
        DateTime defendtime { get; set; }   // Thời gian tổ chức bảo vệ

        public defendcouncil()
        {
            this.code = "";
            this.codeview = "";
            this.name = "";
            this.departmentcode = "";
            this.defendperiodcode = "";
            this.hallcode = "";
            this.defendtime = DateTime.Now;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_code">Mã hội đồng, khóa chính</param>
        /// <param name="_codeview">Mã hội đồng hiển thị</param>
        /// <param name="_name">Tên hội đồng bảo vệ</param>
        /// <param name="_departmentcode">Mã chuyên ngành</param>
        /// <param name="_defendperiodcode"><Mã đợt bảo vệ/param>
        /// <param name="_hallcode">Mã giảng đường</param>
        /// <param name="_defendtime">Thời gian tổ chức bảo vệ</param>
        public defendcouncil(string _code, string _codeview,
            string _name, string _departmentcode, string _defendperiodcode,
            string _hallcode, DateTime _defendtime)
        {
            this.code = _code;
            this.codeview = _codeview;
            this.name = _name;
            this.departmentcode = _departmentcode;
            this.defendperiodcode = _defendperiodcode;
            this.hallcode = _hallcode;
            this.defendtime = DateTime.Now;
        }

    }
}