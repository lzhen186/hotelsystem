using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 招聘类
    /// </summary>
    public class Recruitment1
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string PostType { get; set; }
        public string PostPlace { get; set; }
        public string PostDesc { get; set; }
        public string PostRequire { get; set; }

        public string Experience { get; set; }//工作经验
        public string EduBackground { get; set; }//学历
        public int RequireCount { get; set; }//招聘人数
        public DateTime PublishTime { get; set; }//发布时间
        public string Manager { get; set; }//联系人

        public string PhoneNumber { get; set; }
        public string Email { get; set; }






        public string ltaPostName { get; set; }
    }
}
