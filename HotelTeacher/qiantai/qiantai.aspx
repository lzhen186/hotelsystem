<%@ Page Title="" Language="C#" MasterPageFile="~/qiantai/qiantai.Master" AutoEventWireup="true" CodeBehind="qiantai.aspx.cs" Inherits="HotelTeacher.qiantai.qiantai1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
        *{margin: 0; padding: 0; list-style: none;}
        #tupian{width:1000px; height: 500px; margin: 0px auto;}
        #tupian  ul li{display: none;}
        #tupian  ul li.cur{display: block;}
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">


<div id="tupian">
    <ul id="tupianul">
        <li class="cur"><<img src="../Images/huanjing1.jpg"width="1000px" height="500px"  alt=""/></li>
        <li><img src="../Images/huanjing2.jpg"width="1000px" height="500px"  alt=""/></li>
        <li><img src="../Images/huanjing3.jpg"width="1000px" height="500px"   alt=""/></li>
        <li><img src="../Images/huanjing4.jpg"width="1000px" height="500px"   alt=""/> </li>
        
    </ul>
</div>
 <script>
     window.onload = function () {
         var mytulis = document.getElementById("tupianul").getElementsByTagName("li");
         var nowimg = 0;
         window.setInterval(dong, 1000);
         function dong() {
             if (nowimg < mytulis.length - 1) {
                 nowimg++;
             } else {
                 nowimg = 0;
             }
             for (var i = 0; i <= mytulis.length - 1; i++) {
                 mytulis[i].className = "";
             }
             mytulis[nowimg].className = "cur";
         }
     }
    </script>


</asp:Content>
