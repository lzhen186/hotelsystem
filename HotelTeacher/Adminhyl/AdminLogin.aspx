<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="HotelTeacher.AdminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/AdminCss.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 2254px;
            height: 1499px;
        }
    </style>
</head>
<body>
       <form id="form1" runat="server">
    <div id="container">
         <div id="top">    
         </div>
          <div id="content">
             <div id="loginimg">
                 <img alt="" class="style1" src="../Images/loginimg.jpg" />
             </div>
             <div id="logindiv">
                 <div id="ltitle">
                        管理员登录
                  </div>
                  <div class="litem">登录账号：<asp:TextBox ID="txtLoginId" runat="server" CssClass="txt"></asp:TextBox></div>
                  <div class="litem">登录密码：<asp:TextBox ID="txtLoginPwd" runat="server" CssClass="txt" 
                          TextMode="Password"></asp:TextBox></div>
                  <div class="litem">
                      <asp:Button
                       ID="btnLogin" runat="server" Text="马上登录" onclick="btnLogin_Click" /><asp:Literal ID="ltaMsg" runat="server"></asp:Literal></div>
    
            </div>
        </div>
         <div id="footer">
         版权所有：河北旅游职业学院信息技术系
        </div>
    
    </div>
    </form>
</body>
</html>
