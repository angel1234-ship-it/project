<%@ Page Title="" Language="C#" MasterPageFile="~/Farmer/FarmerMaster.master" AutoEventWireup="true" CodeFile="ShopSearch.aspx.cs" Inherits="Farmer_Default" %>

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
                District:<asp:DropDownList ID="dddistrict" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dddistrict_SelectedIndexChanged" Width="300px">
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp; Place:<asp:DropDownList ID="ddplace" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddplace_SelectedIndexChanged" Width="300px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="dddistrict" ErrorMessage="please select" InitialValue="--select--" style="color: #FF0000"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddplace" ErrorMessage="please select " InitialValue="--select--" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="datalistshop" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" RepeatColumns="5" RepeatDirection="Horizontal" OnItemCommand="datalistshop_ItemCommand">
                    <AlternatingItemStyle BackColor="#F7F7F7" />
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>Shop Name:<asp:Label ID="lblname" runat="server" Text='<%# Eval("shop_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td> <img src="../Assests/ShopDocs/<%#Eval("shop_photo") %>" width="150" height="100" /> </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnview" runat="server" CommandArgument='<%# Eval("shop_id") %>' CommandName="vm" Text="ViewMore" CausesValidation="False" />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                </asp:DataList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

