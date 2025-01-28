<%@ Page Title="" Language="C#" MasterPageFile="~/Agency/AgencyMaster.master" AutoEventWireup="true" CodeFile="FarmerSeePineapple.aspx.cs" Inherits="Agency_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                Category:<asp:DropDownList ID="ddcategory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddcategory_SelectedIndexChanged" Width="300px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="datalistpineapple" runat="server" RepeatDirection="Horizontal" CellPadding="4" ForeColor="#333333" OnItemCommand="datalistpineapple_ItemCommand">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td><img src="../Assests/FarmerProduct/<%#Eval("farmerproduct_photo") %>" width="150" height="100" /></td>
                            </tr>
                            <tr>
                                <td>Pineapple:<asp:Label ID="lbproduct" runat="server" Text='<%# Eval("farmerproduct_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Price:<asp:Label ID="lbprice" runat="server" Text='<%# Eval("farmerproduct_price") %>'></asp:Label>
                                    ₹</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("farmerproduct_id") %>' CommandName="vm" Text="ViewMore" />
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

