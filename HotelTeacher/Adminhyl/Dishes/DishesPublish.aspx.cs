using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace HotelTeacher.Adminhyl.Dishes
{
    public partial class DishesPublish : System.Web.UI.Page
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
                //如果是新增菜品，那就把修改的按钮的可见属性设为false
                if (Request.QueryString["Operation"] == "0")
                {
                    this.btnEdit.Visible = false;
                }
                else if (Request.QueryString["Operation"] == "1")
                {
                    this.btnPublish.Visible = false;
                    int dishId = Convert.ToInt32(Request.QueryString["dishId"]);
                    if (dishId == 0)
                    {
                        Response.Redirect("~/Adminhyl/Default.aspx");
                        return;
                    }
                    ViewState["DishID"] = dishId;
                    //显示要修改的菜品信息
                    Dish objdish = new DishesService().GetDishById(dishId);
                    this.txtDishName.Text = objdish.DishName;
                    this.txtUnitPrice.Text = objdish.UnitPrice.ToString();
                    this.ddlCategory.SelectedValue = objdish.CategoryId.ToString();
                    this.dishImage.ImageUrl = "../../Images/dish/" + dishId + ".png";
                }
                else
                {
                    Response.Redirect("~/Adminhyl/Default.aspx");
                }
            }
        }
        /// <summary>
        /// 新增或修改菜品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnPublish_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txtDishName.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('菜品名不能为空')</script>";
                return;
            }
            if (this.txtUnitPrice.Text.Trim().Length == 0)
            {
                this.ltaMsg.Text = "<script>alert('菜品价格不能为空')</script>";
                return;
            }
            if (this.ddlCategory.SelectedIndex==-1)
            {
                this.ltaMsg.Text = "<script>alert('请选择菜系')</script>";
                return;
            }
            //验证是否是整数
            if (!Common.DataValidate.IsInteger(this.txtUnitPrice.Text))
            {
                this.ltaMsg.Text = "<script>alert('菜品价格必须是整数')</script>";
                return;
            }
            //封装对象
            Dish objDish = new Dish()
            { 
             DishName=this.txtDishName.Text,
             UnitPrice=Convert.ToInt32(this.txtUnitPrice.Text),
             CategoryId=Convert.ToInt32(this.ddlCategory.Text)
            };
            if (ViewState["DishID"] != null)
            { 
            objDish.DishId = Convert.ToInt32(ViewState["DishID"]);
            }
            //存入数据库
            if (this.btnPublish.Visible)
            {
                if (!this.fulImage.HasFile)
                {
                    this.ltaMsg.Text = "<script>alert('必须添加图片')</script>";
                    return;
                }
                int dishId = new DishesService().AddDish(objDish);
                if (dishId > 0)
                {
                    //判断图片大小
                    double filelength = this.fulImage.FileContent.Length / (1024.0 * 1024.0);
                    if (filelength > 2.0)
                    {
                        this.ltaMsg.Text = "<script>alert('图片大小不能超过2M')</script>";
                        return;
                    }
                    //取出选中的图片名称
                    string fileName = fulImage.FileName;
                    //截取字符串
                    if (fileName.Substring(fileName.LastIndexOf(".")).ToLower() != ".png")
                    {
                        this.ltaMsg.Text = "<script>alert('图片必须为png格式')</script>";
                        return;
                    }
                    fileName = dishId + ".png";
                    //上传图片
                    string path = Server.MapPath("~/Images/dish");
                    this.fulImage.SaveAs(path + "/" + fileName);

                    this.ltaMsg.Text = "<script>alert('添加成功')</script>";
                    //清空之前的输入
                    this.txtDishName.Text = "";
                    this.txtUnitPrice.Text = "";
                    this.ddlCategory.SelectedIndex = -1;
                }               
            }
            else
            {
                new DishesService().Modify(objDish);
                if (!this.fulImage.HasFile)
                {
                    this.ltaMsg.Text = "<script>alert('修改成功');location.href='DishesManager.aspx'</script>";
                }
                else
                {
                    double filelength = this.fulImage.PostedFile.ContentLength / (1024.0 * 1024.0);
                    if (filelength > 2.0)
                    {
                        this.ltaMsg.Text = "<script>alert('图片大小不能超过2M')</script>";
                        return;
                    }
                    //取出选中的图片名称
                    string fileName = fulImage.FileName;
                    //截取字符串
                    if (fileName.Substring(fileName.LastIndexOf(".")).ToLower() != ".png")
                    {
                        this.ltaMsg.Text = "<script>alert('图片必须为png格式')</script>";
                        return;
                    }
                    fileName = objDish.DishId + ".png";
                    //上传图片
                    string path = Server.MapPath("~/Images/dish");
                    this.fulImage.SaveAs(path + "/" + fileName);
                    this.ltaMsg.Text = "<script>alert('修改成功');location.href='.aspx'</script>";
                }
            }
       }
       
    }
}