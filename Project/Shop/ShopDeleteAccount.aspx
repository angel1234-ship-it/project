<%@ Page Title="" Language="C#" MasterPageFile="~/Shop/ShopMaster.master" AutoEventWireup="true" CodeFile="ShopDeleteAccount.aspx.cs" Inherits="Shop_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 296px;
        }
        .auto-style3 {
            color: #00CC00;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Label ID="lbalert" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">Please select a reason for deactivating the account</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rbreason2" runat="server">
                    <asp:ListItem>Closure of Business</asp:ListItem>
                    <asp:ListItem>Privacy Concerns</asp:ListItem>
                    <asp:ListItem>Dissatisfication with services</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btndeactivate" runat="server" Text="Deactivate My Account" Font-Bold="true" OnClick="btndeactivate_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Label ID="lbmessage" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

