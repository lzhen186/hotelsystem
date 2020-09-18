using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace HotelTeacher.Adminhyl.News
{
    public partial class NewsManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Repeater1.DataSource = new NewService().GetNewes();
            this.Repeater1.DataBind();

        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            string newsID = ((LinkButton)sender).CommandArgument;
            NewService objnews = new NewService();
            objnews.DelNew(newsID);
            this.Repeater1.DataSource = (null);
            this.Repeater1.DataBind();
            Response.Redirect("NewsManager.aspx");
        }
    }
}