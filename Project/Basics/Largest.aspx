<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="Largest.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 295px;
        }
        .auto-style3 {
            width: 295px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Number1</td>
            <td>
                <asp:TextBox ID="txtnumber1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Number2</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtnumber2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Number3</td>
            <td>
                <asp:TextBox ID="txtnumber3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <br />
                Result</td>
            <td>
                <asp:Button ID="btnlarger" runat="server" OnClick="btnlarger_Click" Text="Larger" />
                <asp:Button ID="btnsmallest" runat="server" OnClick="btnsmallest_Click" Text="smallest" Width="60px" />
                <br />
                <asp:Label ID="lblresult" runat="server" Text="lblResult" Width="80px"></asp:Label>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

