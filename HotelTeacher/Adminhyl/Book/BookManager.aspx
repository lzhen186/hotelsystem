<%@ Page Title="" Language="C#" MasterPageFile="~/Adminhyl/Adminhyl.Master" AutoEventWireup="true" CodeBehind="BookManager.aspx.cs" Inherits="HotelTeacher.Adminhyl.Book.BookManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
  <div class="itemdiv">
        <div class="book-title">
            酒店名称</div>
        <div class="book-title">
            消费时间</div>
        <div class="book-title">
            消费人数</div>
        <div class="book-title">
            包间类型</div>
        <div class="book-title">
            客户姓名</div>
        <div class="book-title">
            联系电话</div>
        <div class="book-title" style="width: 152px;">
            操作</div>

      <asp:Repeater ID="Repeater1" runat="server">
      <ItemTemplate>
      
        <div class="book-title"> <%#Eval("HotelName")%>        </div>
        <div class="book-title">
           <%#Eval("ConsumeTime","{0:yyyy-MM-dd}")%>  </div>
        <div class="book-title">
             <%#Eval("ConsumePersons") %>人</div>
        <div class="book-title">
           <%#Eval("RoomType") %>  </div>
        <div class="book-title">
             <%#Eval("CustomerName") %> </div>
        <div class="book-title">
           <%#Eval("CustomerPhone") %> </div>
        <div class="book-title" style="width: 152px;">
           <asp:LinkButton ID="lbtnPass" OnClick="lbtn_Click" CommandArgument='<%#Eval("BookId") %>' CommandName="1" runat="server">通过</asp:LinkButton>
           <asp:LinkButton ID="lbtnCancel" OnClick="lbtn_Click"  CommandArgument='<%#Eval("BookId") %>'  CommandName="-1" runat="server">撤销</asp:LinkButton>
           <asp:LinkButton ID="lbtnClose" OnClick="lbtn_Click" CommandArgument='<%#Eval("BookId") %>'  CommandName="2" runat="server">关闭</asp:LinkButton>
          
        </div>
          
        <div class="bookdetail">
            <div class="book-Time">
                预定时间：  <%#Eval("BookTime") %></div>
            <div class="book-Time">
                电子邮件： <%#Eval("CustomerEmail") %></div>
            <div class="book-Time">
                预定状态： <%#Eval("OrderStatus") %>&nbsp;（0：未审核&nbsp;1：审核通过）</div>
            <div class="book-comment">
             <%#Eval("Comments") %>
                </div>
        </div>
      
      </ItemTemplate>
      </asp:Repeater>
       
               
           
        <asp:Literal ID="ltaMsg" runat="server"></asp:Literal>
    </div>
</asp:Content>
