using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDATN.Models
{
    /*
     Tên bảng: defendperiod
Mô tả: Thông tin về đợt bảo vệ đồ án tốt nghiệp

         */
    public class defendperiod
    {
        public string code { get; set; }
        public int year { get; set; }
        public string name { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }

        public defendperiod()
        {
            this.code = "";
            this.year = DateTime.Now.Year;
            this.name = "";
            this.startdate = DateTime.Now;
            this.enddate = DateTime.Now;
        }
        /// <summary>
        /// Hàm khởi tạo có tham số Thông tin về đợt bảo vệ đồ án tốt nghiệp
        /// </summary>
        /// <param name="_code">Mã đợi bảo vệ</param>
        /// <param name="_year">năm bảo vệ</param>
        /// <param name="_name">Tên đợt bảo vệ</param>
        /// <param name="_startdate">ngày bắt đầu</param>
        /// <param name="_enddate">ngày kết thúc</param>
        public defendperiod(string _code,int _year,string _name,DateTime _startdate,DateTime _enddate)
        {
            this.code = _code;
            this.year = _year;
            this.name = _name;
            this.startdate = _startdate;
            this.enddate =_enddate;
        }

    }
}