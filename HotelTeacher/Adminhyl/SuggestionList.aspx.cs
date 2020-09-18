using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;


namespace HotelTeacher.Adminhyl
{
    public partial class SuggestionList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Repeater1.DataSource = new SuggestionService().GetSuggest();
                this.Repeater1.DataBind();

            }

        }

        protected void lbtn_Click(object sender, EventArgs e)
        {
            
            this.Repeater1.DataSource = new SuggestionService().GetSuggest();
            this.Repeater1.DataBind();
        }
    }
}