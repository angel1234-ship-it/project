<%@ Page Title="" Language="C#" MasterPageFile="~/Shop/ShopMaster.master" AutoEventWireup="true" CodeFile="ProductDeliveryView.aspx.cs" Inherits="Shop_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 151px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2"></td>
            <td>
                <asp:DataList ID="datalistdelivery" runat="server" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td> <img src="../Assests/ShopDocs/<%#Eval("shopproduct_photo") %>" width="100" height="100" /></td>
                            </tr>
                            <tr>
                                <td>Product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="lbpro" runat="server" Text='<%# Eval("shopproduct_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Order&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="lborder" runat="server" Text='<%# Eval("productbooking_quantity") %>'></asp:Label>
                                    Kg/Qty</td>
                            </tr>
                            <tr>
                                <td>Amount&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="lbprice" runat="server" Text='<%# Eval("productbooking_amount") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Payment Date&nbsp;
                                    <asp:Label ID="lbpayment" runat="server" Text='<%# Eval("payment_date") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Status&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label1" runat="server" style="color: #3333FF" Text="Delivered"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
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

