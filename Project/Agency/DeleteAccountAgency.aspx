<%@ Page Title="" Language="C#" MasterPageFile="~/Agency/AgencyMaster.master" AutoEventWireup="true" CodeFile="DeleteAccountAgency.aspx.cs" Inherits="Agency_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="w-100">
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td>
                <asp:Label ID="lbalert" runat="server" style="color: #FF0000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td>
                <asp:Label ID="lbmsg" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td style="color: #00CC00">Please select reason for deactivating the account</td>
        </tr>
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rbreason" runat="server">
                    <asp:ListItem>Closure of Business</asp:ListItem>
                    <asp:ListItem>Privacy Concerns</asp:ListItem>
                    <asp:ListItem>Dissatisfaction with Service</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Deactivate My Account" Font-Bold="true" BackColor="#00cc00" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 310px">&nbsp;</td>
            <td>
                <asp:Label ID="lbmessage" runat="server" style="color: #FF0000"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>


