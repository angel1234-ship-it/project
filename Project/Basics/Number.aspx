<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="Number.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 290px;
        }
        .auto-style3 {
            width: 290px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Number</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtnumber" runat="server" OnTextChanged="txtnumber_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsum" runat="server" OnClick="btnsum_Click" Text="Sum" Width="69px" />
                <asp:Button ID="btnreverse" runat="server" Text="Reverse" Width="69px" OnClick="btnreverse_Click" />
                <asp:Button ID="btnpalindrome" runat="server" Text="Palindrome" Width="69px" OnClick="btnpalindrome_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Result</td>
            <td>
                <asp:Label ID="lblresult" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

