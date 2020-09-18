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
    public partial class RecruitmentPublish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }



        protected void btnRecr_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txtPostName.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('职位名称不能为空')</script>";
                return;
            }
            if (this.txtPostType.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('职位类型不能为空')</script>";
                return;
            }
            if (this.txtExp.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('工作经验不能为空')</script>";
                return;
            }
            if (this.txtEduBac.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('学历要求不能为空')</script>";
                return;
            }
            if (this.txtPlace.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('工作地点不能为空')</script>";
                return;
            }
            if (this.txtRecCount.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('招聘人数不能为空')</script>";
                return;
            }
            if (this.txtPublisTime.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('发布时间不能为空')</script>";
                return;
            }
            if (this.txtDesc.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('职位描述不能为空')</script>";
                return;
            }
            if (this.txtRequire.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('招聘要求不能为空')</script>";
                return;
            }
            if (this.txtManager.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('联 系 人不能为空')</script>";
                return;
            }
            if (this.txtPhone.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('联系电话不能为空')</script>";
                return;
            }
            if (this.txtEmail.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('电子邮件不能为空')</script>";
                return;
            }
            //封装对象
            Recruitment1 objRecr = new Recruitment1()
            {
                PostName=this.txtPostName.Text.ToString(),
                PostType=this.txtPostType.Text.ToString(),
                Experience=this.txtExp.Text.ToString(),
                EduBackground=this.txtEduBac.Text.ToString(),
                PostPlace=this.txtPlace.Text.ToString(),
                RequireCount=Convert.ToInt32(this.txtRecCount.Text),
                PublishTime=Convert.ToDateTime(this.txtPublisTime.Text),
                PostDesc=this.txtDesc.Text.ToString(),
                PostRequire=this.txtRequire.Text.ToString(),
                Manager=this.txtManager.Text.ToString(),
                PhoneNumber=this.txtPhone.Text.ToString(),
                Email=this.txtEmail.Text.ToString()

             };
            if (ViewState["PostId"] != null)
            {
                objRecr.PostId = Convert.ToInt32(ViewState["PostId"]);
            
            }
            //存入数据库
            if (this.btnRecr.Visible)
            {
                int postId = new RecruitmentService().AddRecr(objRecr);
                if (postId > 0)
                {
                    this.ltaMsg.Text = "<script>alert('添加成功')</script>";
                }
                this.txtPostName.Text="";
               this.txtPostType.Text="";
                this.txtExp.Text="";
               this.txtEduBac.Text="";
                this.txtPlace.Text="";
               this.txtRecCount.Text="";
               this.txtPublisTime.Text="";
               this.txtDesc.Text="";
                this.txtRequire.Text="";
               this.txtManager.Text="";
               this.txtPhone.Text="";
               this.txtEmail.Text = "";
            }


        }



    }
}

