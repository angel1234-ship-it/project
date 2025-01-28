<%@ Page Title="" Language="C#" MasterPageFile="~/Agency/AgencyMaster.master" AutoEventWireup="true" CodeFile="PaymentView.aspx.cs" Inherits="Agency_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 115px;
        }
        .auto-style3 {
            width: 115px;
            height: 396px;
        }
        .auto-style4 {
            height: 396px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">
                <asp:DataList ID="datalistpayment" runat="server" CellPadding="4" ForeColor="#333333" RepeatDirection="Horizontal">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td><img src="../Assests/FarmerProduct/<%#Eval("farmerproduct_photo") %>" width="100" height="100" /></td>
                            </tr>
                            <tr>
                                <td>Category&nbsp;&nbsp;
                                    <asp:Label ID="lbcate" runat="server" Text='<%# Eval("category_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Pineapple&nbsp;
                                    <asp:Label ID="lbpro" runat="server" Text='<%# Eval("farmerproduct_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Order&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="lborder" runat="server" Text='<%# Eval("productbooking_quantity") %>'></asp:Label>
                                    Kg</td>
                            </tr>
                            <tr>
                                <td>Amount&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("productbooking_amount") %>'></asp:Label>
                                    ₹/-</td>
                            </tr>
                            <tr>
                                <td>Order Date <asp:Label ID="lbpayment" runat="server" Text='<%# Eval("payment_date") %>' style="color: #0000FF"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
            <td class="auto-style4"></td>
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

