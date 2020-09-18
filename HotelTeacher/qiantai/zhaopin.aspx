<%@ Page Title="" Language="C#" MasterPageFile="~/qiantai/qiantai.Master" AutoEventWireup="true" CodeBehind="zhaopin.aspx.cs" Inherits="HotelTeacher.qiantai.zhaopin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Rec.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div class="outdiv">
        <div class="titlediv">
            <div class="position">
                招聘职位</div>
            <div class="place">
                工作地点</div>
            <div class="needcount">
                招聘人数</div>
            <div class="detail">
                详情     </div>
       </div>
    <asp:Repeater ID="Repeater1" runat="server" >
    <ItemTemplate>
        <div class="itemdiv">
           <div class="position">
                <a href="#"><%#Eval("PostName")%></a>
                <a href="#"><%#Eval("PostType")%></a>
                <a href="#"><%#Eval("Experience")%></a>
                <a href="#"><%#Eval("EduBackground")%></a>
            </div>
            <div class="place">
              <%#Eval("PostPlace")%>
            </div>
            <div class="needcount">
              <%#Eval("RequireCount")%>   
            </div>
          
        
      </div>
       
    </ItemTemplate>

    </asp:Repeater>   
     </div>
  
</asp:Content>
