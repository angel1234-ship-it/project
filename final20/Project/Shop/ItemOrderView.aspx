<%@ Page Title="" Language="C#" MasterPageFile="~/Shop/ShopMaster.master" AutoEventWireup="true" CodeFile="ItemOrderView.aspx.cs" Inherits="Shop_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:DataList ID="datalistorder" runat="server" CellPadding="4" ForeColor="#333333" RepeatDirection="Horizontal">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td><img src="../Assests/ShopDocs/<%#Eval("shopproduct_photo") %>" width="150" height="100" /></td>
                            </tr>
                            <tr>
                                <td>Product&nbsp;&nbsp;
                                    <asp:Label ID="lbsubtype" runat="server" Text='<%# Eval("subtype_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Product Name
                                    <asp:Label ID="lbname" runat="server" Text='<%# Eval("shopproduct_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Order (Kg/Qty)
                                    <asp:Label ID="lbcount" runat="server" Text='<%# Eval("productbooking_quantity") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Amount&nbsp;&nbsp;
                                    <asp:Label ID="lbamount" runat="server" Text='<%# Eval("productbooking_amount") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Order&nbsp;
                                    <asp:Label ID="lbdate" runat="server" Text='<%# Eval("payment_date") %>' style="color: #3333FF"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

