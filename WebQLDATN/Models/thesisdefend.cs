using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDATN.Models
{
    //    Tên bảng: thesisdefend
    //Mô tả: Thông tin về bảo vệ đồ án tốt nghiệp

    public class thesisdefend
    {
        string studentcode { get; set; }// K Mã sinh viên
        string defendcouncilcode { get; set; }// K Mã hội đồng
        float defendmark1 { get; set; }// Điểm bảo vệ 1
        float defendmark2 { get; set; }// Điểm bảo vệ 2
        float defendmark3 { get; set; }// Điểm bảo vệ 3
        float defendmark4 { get; set; }// Điểm bảo vệ 4
        float defendmark5 { get; set; }// Điểm bảo vệ 5

        public thesisdefend()
        {
            this.studentcode = "";
            this.defendcouncilcode = "";
            this.defendmark1 = 0;
            this.defendmark2 = 0;
            this.defendmark3 = 0;
            this.defendmark4 = 0;
            this.defendmark5 = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_studentcode">Mã sinh viên</param>
        /// <param name="_defendcouncilcode">Mã hội đồng</param>
        /// <param name="_defendmark1"> Điểm bảo vệ 1</param>
        /// <param name="_defendmark2"> Điểm bảo vệ 2</param>
        /// <param name="_defendmark3"> Điểm bảo vệ 3</param>
        /// <param name="_defendmark4"> Điểm bảo vệ 4</param>
        /// <param name="_defendmark5"> Điểm bảo vệ 5</param>
        public thesisdefend(string _studentcode, string _defendcouncilcode, float _defendmark1, float _defendmark2, float _defendmark3, float _defendmark4, float _defendmark5)
        {
            this.studentcode = "";
            this.defendcouncilcode = "";
            this.defendmark1 = 0;
            this.defendmark2 = 0;
            this.defendmark3 = 0;
            this.defendmark4 = 0;
            this.defendmark5 = 0;
        }

    }
}