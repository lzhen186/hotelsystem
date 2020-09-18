using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace HotelTeacher.qiantai
{
    public partial class caipin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //首次加载
            if (!IsPostBack)
            {
                this.ddlCategory.DataSource = new DishesService().GetAllCategory();
                this.ddlCategory.DataTextField = "CategoryName";
                this.ddlCategory.DataValueField = "CategoryId";
                this.ddlCategory.DataBind();
                //显示菜品信息
                this.Repeater1.DataSource = new DishesService().GetDish(null);
                this.Repeater1.DataBind();
            }

        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            this.Repeater1.DataSource = new DishesService().GetDish(this.ddlCategory.SelectedValue.ToString());
            this.Repeater1.DataBind();
        }

    }
}