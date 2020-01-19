<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="Medicare.Admin.AddPrescribed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

        <div>
                     <h2>Add Product</h2>   
                    </div>
                              
                 <!-- /. ROW  -->
    <table >
        <tr>
            <td>Product name</td>
            <td><asp:TextBox ID="tn" runat="server" required="required"></asp:TextBox></td>
        </tr>

         <tr>
            <td>Product Discription</td>
            <td><asp:TextBox ID="td" runat="server" required="required"></asp:TextBox></td>
        </tr>

         <tr>
            <td>Product Price</td>
            <td><asp:TextBox  ID="tp" runat="server" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter valid price" ValidationExpression="^[0-9]*$" ControlToValidate="tp"></asp:RegularExpressionValidator>
             </td>
        </tr>

         <tr>
            <td>Product quantity</td>
            <td><asp:TextBox ID="tq" runat="server" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter valid Quantity" ValidationExpression="^[0-9]*$" ControlToValidate="tq"></asp:RegularExpressionValidator>
             </td>

        </tr>

          <tr>
            <td>Category</td>
            <td>
                <asp:DropDownList ID="cat" runat="server">
                    <asp:ListItem Value="0">Select Category</asp:ListItem>
                    <asp:ListItem >Priscribed</asp:ListItem>
                    <asp:ListItem >Non Prescribed</asp:ListItem>
                    <asp:ListItem >General</asp:ListItem>
                    <asp:ListItem >Aurvedic</asp:ListItem>
                </asp:DropDownList>
                

                <asp:RequiredFieldValidator InitialValue="0"  ID="RequiredFieldValidator1" runat="server" ControlToValidate="cat" ErrorMessage="Please select a type"></asp:RequiredFieldValidator>
                

            </td>
        </tr>

         <tr>
            <td>Product image</td>
            <td>
                <asp:FileUpload ID="f1" runat="server" required="required"/>
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="b1" runat="server" text="Upload" OnClick="b1_Click"/>
                 <asp:Label ID="l1" runat="server"></asp:Label>
            </td>
        </tr>

    </table>


</asp:Content>
