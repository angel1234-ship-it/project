<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.master" AutoEventWireup="true" CodeFile="Shopregistration.aspx.cs" Inherits="Guest_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 186px;
        }
        .auto-style3 {
            width: 186px;
            height: 32px;
        }
        .auto-style4 {
            height: 32px;
        }
        .auto-style5 {
            color: #FF0000;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Shop Name<span class="auto-style5">*</span></td>
            <td>
                <asp:TextBox ID="txtshopname" runat="server"  Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtshopname" ErrorMessage="Please enter shopname" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Shop Owner Name<span class="auto-style5">*</span></td>
            <td>
                <asp:TextBox ID="txtownername" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtownername" ErrorMessage="Please enter shopownername" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Address<span class="auto-style5">*</span></td>
            <td>
                <asp:TextBox ID="txtaddress" runat="server" Height="50px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtaddress" ErrorMessage="please enter address" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">District<span class="auto-style5">*</span></td>
            <td>
                <asp:DropDownList ID="dddistrict" runat="server" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="dddistrict_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dddistrict" ErrorMessage="Select District" InitialValue="--select--" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Place<span class="auto-style5">*</span></td>
            <td>
                <asp:DropDownList ID="ddplace" runat="server" Width="300px">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddplace" ErrorMessage="Select place" InitialValue="--select--" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Pincode<span class="auto-style5">*</span></td>
            <td>
                <asp:TextBox ID="txtpin" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtpin" ErrorMessage="Please Enter Pincode" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Email<span class="auto-style5">*</span></td>
            <td>
                <asp:TextBox ID="txtemail" runat="server" Width="300px" AutoPostBack="True" OnTextChanged="txtemail_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtemail" ErrorMessage="Please enter valid email" style="color: #FF0000"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Please enter valid email" style="color: #FF0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:Label ID="lbmsg" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">Contact No<span class="auto-style5">*</span></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtcontact" runat="server" Width="300px" AutoPostBack="True" OnTextChanged="txtcontact_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtcontact" ErrorMessage="Please enter 10 digit number" style="color: #FF0000"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtcontact" ErrorMessage="Please enter 10 digit number" style="color: #FF0000" ValidationExpression="([0-9]{7,10})"></asp:RegularExpressionValidator>
                <asp:Label ID="lbmsg1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Username<span class="auto-style5">*</span></td>
            <td>
                <asp:TextBox ID="txtusername" runat="server" Width="300px" AutoPostBack="True" OnTextChanged="txtusername_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtusername" ErrorMessage="Please enter username" style="color: #FF0000"></asp:RequiredFieldValidator>
                <asp:Label ID="lbmsg2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Password<span class="auto-style5">*</span></td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtpassword" ErrorMessage="Please enter password" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Confirm password<span class="auto-style5">*</span></td>
            <td>
                <asp:TextBox ID="txtconfirmpassword" runat="server" Width="300px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtconfirmpassword" ErrorMessage="Password mismatch" style="color: #FF0000"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Security Questions<span class="auto-style5">*</span></td>
            <td>
                <asp:DropDownList ID="ddshop" runat="server" AutoPostBack="True" Width="301px" >
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Who is your favorite actor</asp:ListItem>
                    <asp:ListItem>who is your favorite singer</asp:ListItem>
                    <asp:ListItem>what is your pet name</asp:ListItem>
                    <asp:ListItem>Which is your favorite food</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="ddshop" ErrorMessage="Please select" InitialValue="--select--" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Security Answers<span class="auto-style5">*</span></td>
            <td>
                <asp:TextBox ID="txtanswers" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtanswers" ErrorMessage="please enter answer" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Photo<span class="auto-style5">*</span></td>
            <td>
                <asp:FileUpload ID="fileimage" runat="server" Width="300px" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="fileimage" ErrorMessage="Please choose file" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">ID Proof<span class="auto-style5"> *<br />
                <br />
                </span></td>
            <td>
                <asp:FileUpload ID="fileProof" runat="server" Width="300px" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="fileProof" ErrorMessage="Please choose file" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="80px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
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

