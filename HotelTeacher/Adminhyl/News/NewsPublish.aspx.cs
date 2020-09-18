using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;


namespace HotelTeacher.Adminhyl.News
{
    public partial class NewsPublish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPublish_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txtNewsTitle.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('新闻标题不能为空')</script>";
                return;
            }
            //封装对象
            News1 objNews = new News1()
            {
                NewsTitle = this.txtNewsTitle.Text.ToString(),
                CategoryId = Convert.ToInt32(this.ddlCategory.Text),
                NewsContents = this.txtContent.InnerText.ToString()

            };

             if (ViewState["NewsID"] != null)
             {
                  objNews.NewsId = Convert.ToInt32(ViewState["NewsID"]);
             }

            //存入数据库
             if (this.btnPublish.Visible)
             {
                 int newsId = new NewService().AddNews(objNews);
                 if (newsId > 0)
                 {
                     this.ltaMsg.Text = "<script>alert('添加成功')</script>";
                 }
                 this.txtNewsTitle.Text = "";
                 this.txtContent.InnerText = "";

             }
            
        }
        




        protected void btnEdit_Click(object sender, EventArgs e)
        
            
             {
                 //封装对象
                 News1 objNews = new News1()
                 {
                     NewsTitle = this.txtNewsTitle.Text.ToString(),
                     CategoryId = Convert.ToInt32(this.ddlCategory.Text),
                     NewsContents = this.txtContent.InnerText.ToString()

                 };

                 if (ViewState["NewsID"] != null)
                 {
                     objNews.NewsId = Convert.ToInt32(ViewState["NewsID"]);
                 }

                 //存入数据库
                 if (this.btnPublish.Visible)
                 {
                     int newsId = new NewService().ModifyNew(objNews);
                     
                     {
                         this.ltaMsg.Text = "<script>alert('修改成功');location.href='NewsManager.aspx'</script>";
                     }
                     
                 }
             }


        

    }
}