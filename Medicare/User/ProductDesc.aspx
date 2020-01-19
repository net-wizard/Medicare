<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="ProductDesc.aspx.cs" Inherits="Medicare.User.ProductDesc" %>

<asp:Content ID="con5" ContentPlaceHolderID="a1" runat="server">
    <style>
        .xyz {
            background: url(images/info.png);
        }

        div.name {
            text-align: center;
            font-size: 25px;
            margin-top: 10px;
        }

        div.detail {
            margin: 10px;
            margin-top: -31px;
        }

        div.ab {
            margin-bottom: 5px;
        }

        .buttsub {
            margin: 10px;
            position: absolute;
            top: 384px;
            left: 500px;
        }

        .buttsub1 {
            margin: 10px;
            position: absolute;
            top: 384px;
            left: 416px;
        }

        img.abc {
            height: 300px;
            object-fit: contain;
            object-position: center;
        }

        ._1QrSNG {
            margin-top: 24px;
            border-radius: 2px 2px 0 0;
            background-color: #fff;
            border: 1px solid #f0f0f0;
            border-bottom: none;
            padding: 24px;
            color: #212121;
        }

            ._1QrSNG ._2HVvN7 {
                font-size: 24px;
                font-weight: 500;
                line-height: 1;
            }

            ._1QrSNG ._3u-uqB {
                font-size: 14px;
                font-weight: 400;
                line-height: 1.29;
                color: #212121;
                padding-top: 16px;
            }

        .qty {
            margin: 10px;
            position: absolute;
            top: 384px;
            left: 244px;
        }

        .l123 {
            padding: 5px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">



    <asp:Repeater ID="d1" runat="server">
        <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate>

            <div class="xyz" style="height: 300px; width: 599px; border-style: solid; border-width: 1px;">

                <div style="height: 300px; width: 200px; float: left; border-style: solid; border-width: 1px;">
                    <img class="abc" src='../<%#Eval("image") %>' height="300px" width="200px" />
                </div>

                <div style="height: 300px; width: 395px; float: left; border-style: solid; border-width: 1px;">
                    <div class="name">
                        <%#Eval("name") %>
                    </div>
                    <br />
                    <div class="detail">
                        <div class="ab">
                            <div class="_1QrSNG">
                                <div class="_2HVvN7">Product Description</div>
                                <div class="_3u-uqB">
                                    <%#Eval("desc")  %>
                                </div>
                            </div>
                        </div>
                        
                        <div class="ab">Quantity: <%#Eval ("qty") %></div>

                        <div class="ab">Price: &#x20b9;<%#Eval ("price") %></div>

                        <div class="ab">Catagory: <%#Eval ("cat") %></div>
                        <br />
                    </div>
                   
                    <!-- <table>
                        <tr>
                           -->
                   
                    <!--</tr>
                    </table>-->
                    

                   
                </div>


            </div>


        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
    </asp:Repeater>


   


</asp:Content>
