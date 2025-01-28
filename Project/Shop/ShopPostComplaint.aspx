<%@ Page Title="" Language="C#" MasterPageFile="~/Shop/ShopMaster.master" AutoEventWireup="true" CodeFile="ShopPostComplaint.aspx.cs" Inherits="Shop_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 240px;
        }
        .auto-style3 {
            color: #FF0000;
        }
        .auto-style5 {
            width: 240px;
            color: #009933;
        }
        .auto-style6 {
            color: #009933;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">Title<span class="auto-style3">*</span></td>
            <td>
                <asp:TextBox ID="txttitle" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txttitle" ErrorMessage="please enter title" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2"><span class="auto-style6">Complaint</span><span class="auto-style3">*</span></td>
            <td>
                <asp:TextBox ID="txtcomplaint" runat="server" Height="50px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcomplaint" ErrorMessage="please enter complaint" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsend" runat="server" OnClick="btnsend_Click" Text="Send" Width="80px" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="80px" OnClick="btncancel_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

