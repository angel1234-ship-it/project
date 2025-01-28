<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="Calculator.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Number-1</td>
            <td>
                <asp:TextBox ID="txtnumber1" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Number-2</td>
            <td>
                <asp:TextBox ID="txtnumber2" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnADD" runat="server" Text="+" Width="90px" OnClick="btnADD_Click" />
                <asp:Button ID="btnminus" runat="server" Text="-" OnClick="btnminus_Click" Width="90px" />
                <asp:Button ID="btnpro" runat="server" Text="*" OnClick="btnpro_Click" Width="69px" />
                <asp:Button ID="btndiv" runat="server" Text="/" OnClick="btndiv_Click" Width="69px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Result</td>
            <td>
                <asp:Label ID="lblresult" runat="server"></asp:Label>
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
    </table>
</asp:Content>

