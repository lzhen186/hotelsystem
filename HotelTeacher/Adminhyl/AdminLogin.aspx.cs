using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;
namespace HotelTeacher
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //验证数据
            if (this.txtLoginId.Text.Trim().Length == 0) {
                this.ltaMsg.Text = "请输入用户名";
                return;
            }
            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "请输入密码";
                return;
            }
            //封装数据
            SysAdmin objAdmin = new SysAdmin() { 
             LoginId=Convert.ToInt32(this.txtLoginId.Text),
             LoginPwd=this.txtLoginPwd.Text
            };
            objAdmin = new AdminService().Login(objAdmin);
            if (objAdmin != null)
            {
                Session["Admin"] = objAdmin;
                Response.Redirect("Default.aspx");
            }
            else
            {
                this.ltaMsg.Text = "<script>alert('用户名或密码错误')</script>";
                return;
            }
        }
    }
}