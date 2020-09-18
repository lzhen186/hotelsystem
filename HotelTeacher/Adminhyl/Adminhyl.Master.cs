using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;

namespace HotelTeacher.Adminhly
{
    public partial class Adminhyl : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                this.ltaAdmin.Text = "欢迎您:" + ((SysAdmin)Session["Admin"]).LoginName;
            }
            else
            {
                Response.Redirect("~/Adminhyl/AdminLogin.aspx");
            
            }

        }
    }
}