<%@ Page Title="" Language="C#" MasterPageFile="~/qiantai/qiantai.Master" AutoEventWireup="true" CodeBehind="xinwen.aspx.cs" Inherits="HotelTeacher.qiantai.xinwen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Dishes.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div class="itemdiv">
        <div class="newsitem-title-1">
            发布时间</div>
        <div class="newsitem-title-2">
            新闻标题</div>
        <div class="newsitem-title-2">
            新闻内容</div>
      
     <asp:Repeater ID="Repeater1" runat="server" >
     <ItemTemplate>
     <div class="newsitem-title-1">
           <%#Eval("PublishTime")%></div>
        <div class="newsitem-title-2">
            <a href='/CompanyNews/NewsDetail.aspx?newsId=<%#Eval("NewsId")%>' target="_blank"> <%#Eval("NewsTitle")%></a></div>
        <div class="newsitem-title-2">
            <%#Eval("NewsContents")%>
        </div>
        
        
     </ItemTemplate>

     </asp:Repeater>
    
    </div>
</asp:Content>
