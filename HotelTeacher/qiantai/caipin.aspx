<%@ Page Title="" Language="C#" MasterPageFile="~/qiantai/qiantai.Master" AutoEventWireup="true" CodeBehind="caipin.aspx.cs" Inherits="HotelTeacher.qiantai.caipin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Dishes.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
  
    <div id="dishlistdiv">
           <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
               <div class="dishlist-item">
              <div class="dishlist-img">
                 <img src='../../Images/dish/<%#Eval("DishId") %>.png' alt="" />
             </div>
            <div class="dishlist-txt">
                菜品名称：<%#Eval("DishName") %></div>
            <div class="dishlist-txt">
                菜品分类：<%#Eval("CategoryName") %></div>
            <div class="dishlist-txt">
                菜品价格：<%#Eval("UnitPrice") %></div>
           
                   
        </div>
            </ItemTemplate>
            </asp:Repeater>
     

    </div>

      <div id="dishcategory">
        菜品分类：<asp:DropDownList ID="ddlCategory" runat="server" CssClass="btncss">
        </asp:DropDownList>
        &nbsp;<asp:Button ID="btnQuery" CssClass="btncss" runat="server" Text="提交查询" 
            onclick="btnQuery_Click"  />
    </div>
</asp:Content>
