using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDATN.Models
{
    //    Tên bảng: defendcouncilduty
    //Mô tả: Thông tin về chức vụ trong hội đồng bảo vệ đồ án

    public class defendcouncilduty
    {
        string code { get; set; }//Mã chức vụ, khóa chính
        string name { get; set; }//    Tên chức vụ

        public defendcouncilduty()
        {
            this.code = "";
            this.name = "";
        }
        /// <summary>
        /// Hàm tạo có tham số  Thông tin về chức vụ trong hội đồng bảo vệ đồ án
        /// </summary>
        /// <param name="_code">Mã chức vụ, khóa chính</param>
        /// <param name="_name"> Tên chức vụ</param>
        public defendcouncilduty(string _code, string _name)
        {
            this.code = _code;
            this.name = _name;
        }
    }
}