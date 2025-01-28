<%@ Page Title="" Language="C#" MasterPageFile="~/Farmer/FarmerMaster.master" AutoEventWireup="true" CodeFile="ShopSeeItems.aspx.cs" Inherits="Farmer_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                Type:<asp:DropDownList ID="ddsubtype" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddtype_SelectedIndexChanged" Width="300px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="datalistshop" runat="server" CellPadding="4" ForeColor="#333333" RepeatDirection="Horizontal" OnItemCommand="datalistshop_ItemCommand">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td> <img src="../Assests/ShopDocs/<%#Eval("shopproduct_photo") %>" width="150" height="100" />  </td>
                            </tr>
                            <tr>
                                <td>Product:&nbsp;
                                    <asp:Label ID="lbproduct" runat="server" Text='<%# Eval("shopproduct_name") %>'></asp:Label>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>Price&nbsp;&nbsp;&nbsp; :<asp:Label ID="lbprice" runat="server" Text='<%# Eval("shopproduct_price") %>'></asp:Label>
                                    ₹</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnview" runat="server" CommandArgument='<%# Eval("shopproduct_id") %>' CommandName="vm" Text="ViewMore" />
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

