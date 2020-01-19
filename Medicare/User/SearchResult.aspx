<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="Medicare.User.SearchResult" %>
<asp:Content ID="content2" ContentPlaceHolderID="a1" runat="server">
       <style>

       
.products ul{ list-style-type: none;}
.products ul li{ position:relative; padding:1px; border:solid 10px #dedede; float:left; width:auto; margin-right:9px; height:383px; overflow:hidden; }
.product-info{ position:absolute; width:153px; top:184px; left:0;}
.product-info h3{ background:#8b0000; color:#fff; padding:6px 10px; margin-bottom:0; }

.products ul li.last{ margin-right:0; }
.products ul li.product{ margin-right:0; }
        
.product-info h4{ font-weight: normal;}
.product-info p{ font-size:16px; line-height:18px; text-transform: uppercase; font-weight: bold; color:#000; padding:5px 0 7px 0;}
.product-info .product-desc{ padding:10px; background:url(images/info.png); width:133px; }

.price { display:block; font-size:21px; color:#8b0000; line-height:23px; }
    </style>

</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <asp:Repeater ID="d1" runat="server">
        <HeaderTemplate> 
     
        </HeaderTemplate>
        <ItemTemplate>
            
             <div class="products">      <ul >
     <li > <a href="ProductDesc.aspx?id=<%#Eval("pid") %>"><img class="resize" src="../<%#Eval("image") %>" alt="" /></a>
            <div class="product-info">
              <h3><%#Eval("name") %></h3>
              <div class="product-desc">
                <h4>In Stock:<%#Eval("qty") %></h4>
                <p><%#Eval("desc") %></p>
                <strong class="price">$<%#Eval("price") %></strong> </div>
            </div>
          </li> 
                 
 </ul></div>
        </ItemTemplate>
        <FooterTemplate>
        
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>