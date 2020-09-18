<%@ Page Title="" Language="C#" MasterPageFile="~/Adminhyl/Adminhyl.Master" AutoEventWireup="true" CodeBehind="SuggestionList.aspx.cs" Inherits="HotelTeacher.Adminhyl.SuggestionList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/AdminCss.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
  <div class="itemdiv">
        <div class="book-title">
            客户姓名</div>
        <div class="book-title">
            消费类型</div>
        <div class="book-title">
            消费建议</div>
        <div class="book-title">
            建议时间</div>
        <div class="book-title">
            联系电话</div>
        <div class="book-title">
            Email</div>
        <div class="book-title" style="width: 198px;">
            操作</div>
            
      <asp:Repeater ID="Repeater1" runat="server">
      <ItemTemplate>
       <div class="bookdetail">
        <div class="suggest-Time"> <%#Eval("CustomerName")%>        </div>
        <div class="suggest-Time">
           <%#Eval("ConsumeDesc")%>  </div>
        <div class="suggest-Time">
             <%#Eval("SuggestionDesc")%></div>
        <div class="suggest-Time">
           <%#Eval("SuggestTime", "{0:yyyy-MM-dd}")%>  </div>
        <div class="suggest-Time">
             <%#Eval("PhoneNumber")%> </div>
        <div class="suggest-Time">
           <%#Eval("Email")%> </div>
        <div class="suggest-Time" style="width: 152px;">
           <asp:LinkButton ID="lbtnPass" OnClick="lbtn_Click" CommandArgument='<%#Eval("StatusId") %>' CommandName="1" runat="server">回复</asp:LinkButton>
      
           <asp:LinkButton ID="lbtnClose" OnClick="lbtn_Click" CommandArgument='<%#Eval("StatusId") %>'  CommandName="2" runat="server">关闭</asp:LinkButton>
          
        </div>
          </div> 
      
      
      </ItemTemplate>
      </asp:Repeater>
       
       </div>        
           
        <asp:Literal ID="ltaMsg" runat="server"></asp:Literal>
    
</asp:Content>
