<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.master" AutoEventWireup="true" CodeFile="Forgotpassword.aspx.cs" Inherits="Guest_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 214px;
        }
        .auto-style2 {
            color: #FF0000;
        }
        .auto-style3 {
            width: 187px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <table class="w-100">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">Email<span class="auto-style2">*</span></td>
            <td>
                <asp:TextBox ID="txtemail" runat="server" AutoPostBack="True" OnTextChanged="txtemail_TextChanged" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="please enter email" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">Security Question</td>
            <td>
            <%--    <asp:TextBox ID="txtquestion" runat="server" OnTextChanged="txtquestion_TextChanged" Width="300px"></asp:TextBox>--%>
                <asp:TextBox ID="txtqns" runat="server" AutoPostBack="True" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">Security Answer<span class="auto-style2">*</span></td>
            <td>
                <asp:TextBox ID="txtanswer" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="please enter security answer" style="color: #FF0000" ControlToValidate="txtanswer"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="btnsend" runat="server" Text="Send" Width="80px" OnClick="btnsend_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Label ID="lbalert" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

