<%@ Page Title="" Language="C#" MasterPageFile="~/Basics/BasicMaster.master" AutoEventWireup="true" CodeFile="salary.aspx.cs" Inherits="Basics_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 313px;
        }
        .auto-style3 {
            width: 313px;
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
            <td class="auto-style2">First Name</td>
            <td>
                <asp:TextBox ID="txtfname" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Last Name</td>
            <td>
                <asp:TextBox ID="txtlname" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Gender</td>
            <td>
                <asp:RadioButtonList ID="rbGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Marital Status</td>
            <td>
                <asp:RadioButtonList ID="rbMarital" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Single</asp:ListItem>
                    <asp:ListItem>Married</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Department</td>
            <td>
                <asp:DropDownList ID="ddDept" runat="server">
                    <asp:ListItem>Marketing</asp:ListItem>
                    <asp:ListItem>Finance</asp:ListItem>
                    <asp:ListItem>Management</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Basic Salary</td>
            <td>
                <asp:TextBox ID="txtbasic" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="70px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Name</td>
            <td>
                <asp:Label ID="lblname" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Gender</td>
            <td class="auto-style4">
                <asp:Label ID="lblgender" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Marital</td>
            <td class="auto-style4">
                <asp:Label ID="lblmarital" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Department</td>
            <td>
                <asp:Label ID="lbldept" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">TA</td>
            <td>
                <asp:Label ID="lblta" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">DA</td>
            <td>
                <asp:Label ID="lblda" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">HRA</td>
            <td>
                <asp:Label ID="lblhra" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">LIC</td>
            <td class="auto-style4">
                <asp:Label ID="lbllic" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">PF</td>
            <td>
                <asp:Label ID="lblpf" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Net Salary</td>
            <td>
                <asp:Label ID="lblnetsalary" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

