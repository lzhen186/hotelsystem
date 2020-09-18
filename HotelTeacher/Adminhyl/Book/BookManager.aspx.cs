using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace HotelTeacher.Adminhyl.Book
{
    public partial class BookManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Repeater1.DataSource = new DIshBookService().GerDishBook();
                this.Repeater1.DataBind();
            
            }

        }

        protected void lbtn_Click(object sender, EventArgs e)
        {
            string bookId = ((LinkButton)sender).CommandArgument;
            string order = ((LinkButton)sender).CommandName;
            int result = new DIshBookService().ModifyOrderStatus(bookId, order);
            if (result == 1)
            {
                this.ltaMsg.Text = "<script>alert('操作成功！')</script>";
            }
            this.Repeater1.DataSource = new DIshBookService().GerDishBook();
            this.Repeater1.DataBind();
        }
    }
}