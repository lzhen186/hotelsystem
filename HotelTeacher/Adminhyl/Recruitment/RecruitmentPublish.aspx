<%@ Page Title="" Language="C#" MasterPageFile="~/Adminhyl/Adminhyl.Master" AutoEventWireup="true" CodeBehind="RecruitmentPublish.aspx.cs" Inherits="HotelTeacher.Adminhyl.Recruitment.RecruitmentPublish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/Rec.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
<div class="item" style="margin-top: 20px;">
        <div class="itemtitle">
            职位名称：
        </div>
        <div class="itemcontent">
            <asp:TextBox ID="txtPostName" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="item">        
        <div class="itemtitle">
            职位类型：
        </div>
        <div class="itemcontent">
            <asp:TextBox ID="txtPostType" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="item">
        <div class="itemtitle">
            工作经验：
        </div>
        <div class="itemcontent">
            <asp:TextBox ID="txtExp" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="item">
        <div class="itemtitle">
            学历要求：
        </div>
        <div class="itemcontent">
             <asp:TextBox ID="txtEduBac" runat="server"></asp:TextBox>
        </div>
    </div> 
     <div class="item">
        <div class="itemtitle">
            工作地点：
        </div>
        <div class="itemcontent">
             <asp:TextBox ID="txtPlace" runat="server"></asp:TextBox>
        </div>
    </div> 
    <div class="item">

        <div class="itemtitle">
            招聘人数：
        </div>
        <div class="itemcontent">
              <asp:TextBox ID="txtRecCount" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="item">
        <div class="itemtitle">
            发布时间：
        </div>
        <div class="itemcontent">
             <asp:TextBox ID="txtPublisTime" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="item">
        <div class="itemtitle">
            职位描述：
        </div>
        <div class="itemcontent">
        </div>
    </div>
    <div class="positiondesc">
         <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
    </div>
    <div class="item">
        <div class="itemtitle">
            招聘要求：
        </div>
        <div class="itemcontent">
        </div>
    </div>
    <div class="positiondesc">
         <asp:TextBox ID="txtRequire" runat="server"></asp:TextBox>
    </div>
    <div class="item">
        <div class="itemtitle">
            联 系 人：
        </div>
        <div class="itemcontent">
             <asp:TextBox ID="txtManager" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="item">
        <div class="itemtitle">
            联系电话：
        </div>
        <div class="itemcontent">
       <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="item">
        <div class="itemtitle">
            电子邮件：
        </div>
        <div class="itemcontent">
             <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
         <div class="txtItemdiv">
            <asp:Button ID="btnRecr" CssClass="btncss" runat="server" Text="立即发布" 
                 onclick="btnRecr_Click" Width="133px" 
                />
                
            <asp:Literal ID="ltaMsg" runat="server"></asp:Literal>
                </div>
    </div>

</asp:Content>
