<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="Ranklist.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 370px;
        }
        .auto-style4 {
            width: 370px;
            height: 29px;
        }
        .auto-style5 {
            height: 29px;
        }
        .auto-style6 {
            width: 370px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            width: 370px;
            height: 31px;
        }
        .auto-style9 {
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">First Name</td>
            <td>
                <asp:TextBox ID="txtfname" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Last Name</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtlname" runat="server"  Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Gender</td>
            <td>
                <asp:RadioButtonList ID="rdbGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Department</td>
            <td>
                <asp:DropDownList ID="ddldept" runat="server" OnSelectedIndexChanged="DropDownDept_SelectedIndexChanged" style="margin-bottom: 0px">
                    <asp:ListItem>CS</asp:ListItem>
                    <asp:ListItem>COMMERCE</asp:ListItem>
                    <asp:ListItem>PHYSICS</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Mark 1</td>
            <td>
                <asp:TextBox ID="txtm1" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Mark 2</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtm2" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Mark 3</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtm3" runat="server" OnTextChanged="TextBox2_TextChanged" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="70px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Name</td>
            <td>
                <asp:Label ID="lblname" runat="server" Width="300px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Gender</td>
            <td class="auto-style7">
                <asp:Label ID="lblgender" runat="server" Width="300px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Department</td>
            <td>
                <asp:Label ID="lbldep" runat="server" Width="300px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Total</td>
            <td>
                <asp:Label ID="lbltotal" runat="server" Width="300px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Percentage</td>
            <td>
                <asp:Label ID="lblpercentage" runat="server" Width="300px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Grade</td>
            <td>
                <asp:Label ID="lblgrade" runat="server" Width="300px"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

