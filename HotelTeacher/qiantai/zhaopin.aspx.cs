using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace HotelTeacher.qiantai
{
    public partial class zhaopin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Repeater1.DataSource = new RecruitmentService().GetAllRecruit();
            this.Repeater1.DataBind();
        }
    }
}