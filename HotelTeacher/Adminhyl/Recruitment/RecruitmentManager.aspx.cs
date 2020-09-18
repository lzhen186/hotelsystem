using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace HotelTeacher.Adminhyl.Recruitment
{
    public partial class RecruitmentManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Repeater1.DataSource = new RecruitmentService().GetAllRecruit();
            this.Repeater1.DataBind();
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            string postID = ((LinkButton)sender).CommandArgument;
            RecruitmentService objpost = new RecruitmentService();
            objpost.RecrDel(postID);
            this.Repeater1.DataSource = (null);
            this.Repeater1.DataBind();
            Response.Redirect("RecruitmentManager.aspx");
        }
    }
}