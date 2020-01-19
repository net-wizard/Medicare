<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Medicare.User.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="a1" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">
<div>
    <style scoped>
        .slider{
            width: 800px;
            height: 400px;
            background: url(images/1.png);
            margin: 100px auto;
            margin-top: 2%;
            animation: slide 30s infinite;
            border:  solid 4px;
        }
        @keyframes slide{
            25%{
                background: url(images/2.png);
            }
             50%{
                background: url(images/3.png);
            }
              75%{
                background: url(images/4.png);
            }
               100%{
                background: url(images/1.png);
            }
        }
    </style>
    <div class="slider">

    </div>
</div>
    <div>
        <style scoped>
            /* project */
.project h1 { 
  text-align:center;
  margin-bottom:30px;
  margin-top:30px;
  padding-bottom:10px;
  border-bottom:1px solid #aeaeae;
   
}
.project a img { 
  margin:auto;
  display:block;
  width:200px;
  height:117px;
  border-radius:5px;
  box-shadow: 0 0px 5px rgba(0,0,0,0.9);
  margin-bottom:10px;
}
.project a b { 
  text-align:center; 
  display:block; 
  color:#000;
  font-size:13px;
}
  
.grid_4 {
                display: inline;
                float: left;
                position: relative;
                margin-left: 10px;
                margin-right: 10px;
                
}
.grid_4{
    width:220px;
}
.grid_4{
    width:300px;
}
        </style>
        <div class="project">


<div class="grid_4">
<a href="General.aspx">
  <img src="images/General.png">
  <b>General </b>
</a>  
</div>

<div class="grid_4">
<a href="Prescribed.aspx">
  <img src="images/Prescribed.png">
  <b>Prescribed</b>
</a>  
</div>

<div class="grid_4">
<a href="NonPrescribed.aspx">
  <img src="images/NonPrescribed.jpg">
  <b>Non Prescribed </b>
</a>  
</div>

<div class="grid_4">
<a href="Aurvedik.aspx">
  <img src="images/Aurvedik.jpg">
  <b>Aurvedik </b>
</a>  
</div>


</div>
    </div>

</asp:Content>
