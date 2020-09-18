<%@ Page Title="" Language="C#" MasterPageFile="~/Adminhyl/Adminhyl.Master" AutoEventWireup="true" CodeBehind="NewsManager.aspx.cs" Inherits="HotelTeacher.Adminhyl.News.NewsManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
  <div class="itemdiv">
        <div class="newsitem-title-1">
            发布时间</div>
        <div class="newsitem-title-2">
            新闻标题</div>
        <div class="newsitem-title-2">
            新闻内容</div>
        <div class="newsitem-title-3" style="width: 110px;">
            操作</div>
     <asp:Repeater ID="Repeater1" runat="server" >
     <ItemTemplate>
     <div class="newsitem-title-1">
           <%#Eval("PublishTime")%></div>
        <div class="newsitem-title-2">
            <a href='/CompanyNews/NewsDetail.aspx?newsId=<%#Eval("NewsId")%>' target="_blank"> <%#Eval("NewsTitle")%></a></div>
        <div class="newsitem-title-2">
            <%#Eval("NewsContents")%>
        </div>
        <div class="newsitem-title-3" style="width: 110px;">
            <a href='NewsPublish.aspx?Operation=1&newsId=<%#Eval("NewsId")%>'>修改</a> 
            <asp:LinkButton ID="btnDel"  OnClientClick='return confirm("确定删除？")' CommandArgument='<%#Eval("NewsId")%>' 
              runat="server"> 删除</asp:LinkButton></div> 
     </ItemTemplate>

     </asp:Repeater>
    <asp:Literal ID="ltaMsg" runat="server"></asp:Literal>
    </div>
</asp:Content>
