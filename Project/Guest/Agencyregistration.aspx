<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.master" AutoEventWireup="true" CodeFile="Agencyregistration.aspx.cs" Inherits="Guest_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 258px;
        }
        .auto-style3 {
            width: 258px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 258px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
        }
        .auto-style7 {
            width: 258px;
            height: 33px;
        }
        .auto-style8 {
            height: 33px;
        }
        .auto-style9 {
            color: #FF0000;
        }
        .auto-style10 {
            width: 258px;
            height: 28px;
        }
        .auto-style11 {
            height: 28px;
        }
        .auto-style12 {
            width: 258px;
            height: 24px;
        }
        .auto-style13 {
            height: 24px;
        }
        .auto-style14 {
            width: 223px;
        }
        .auto-style15 {
            width: 223px;
            height: 30px;
        }
        .auto-style16 {
            width: 223px;
            height: 24px;
        }
        .auto-style17 {
            width: 223px;
            height: 28px;
        }
        .auto-style18 {
            width: 223px;
            height: 33px;
        }
        .auto-style19 {
            width: 223px;
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br /><br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">Agency Name<span class="auto-style9">*</span></td>
            <td>
                <asp:TextBox ID="txtname" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="Please  Enter Agency Name" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">District<span class="auto-style9">*</span></td>
            <td>
                <asp:DropDownList ID="dddistrict" runat="server" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="dddistrict_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="dddistrict" ErrorMessage="select District" InitialValue="--select--" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">Place<span class="auto-style9">*</span></td>
            <td>
                <asp:DropDownList ID="ddplace" runat="server" Width="300px">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddplace" ErrorMessage="Select Place" InitialValue="--select--" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">Pincode<span class="auto-style9">*</span></td>
            <td>
                <asp:TextBox ID="txtpin" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtpin" ErrorMessage="Please Enter Pincode" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">Email<span class="auto-style9">*</span></td>
            <td>
                <asp:TextBox ID="txtemail" runat="server" Width="300px" AutoPostBack="True" OnTextChanged="txtemail_TextChanged1"></asp:TextBox>
                <span class="auto-style9">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtemail" ErrorMessage="Please Enter Vaild email"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Please Enter Valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </span>
                <asp:Label ID="lbmsg2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">Contact No<span class="auto-style9">*</span></td>
            <td>
                <asp:TextBox ID="txtcontact" runat="server" Width="300px" AutoPostBack="True" OnTextChanged="txtcontact_TextChanged"></asp:TextBox>
                <span class="auto-style9">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtcontact" ErrorMessage="Please Enter 10 Digit Number"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtcontact" ErrorMessage="Please Enter 10 Digit Number" ValidationExpression="([0-9]{7,10})"></asp:RegularExpressionValidator>
                </span>
                <asp:Label ID="lbmsg" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">Username<span class="auto-style9">*</span></td>
            <td>
                <asp:TextBox ID="txtuser" runat="server" Width="300px" AutoPostBack="True" OnTextChanged="txtuser_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtuser" ErrorMessage="Please Enter Username" style="color: #FF0000"></asp:RequiredFieldValidator>
                <asp:Label ID="lbmsg1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">Password<span class="auto-style9">*</span></td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtpassword" ErrorMessage="Please Enter Password" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style15">Confirm Password<span class="auto-style9">*</span></td>
            <td class="auto-style6">
                <asp:TextBox ID="txtconfirmpassword" runat="server" Width="300px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtconfirmpassword" ErrorMessage="Password Mismatch" style="color: #FF0000"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style16">Address<span class="auto-style9">*</span></td>
            <td class="auto-style13">
                <asp:TextBox ID="txtaddress" runat="server" Height="50px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtaddress" ErrorMessage="Please Enter Address" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style17">Security Questions<span class="auto-style9">*</span></td>
            <td class="auto-style11">
                <asp:DropDownList ID="ddsecurity" runat="server" AutoPostBack="True"  Width="300px">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>What is the name of your favorite pet</asp:ListItem>
                    <asp:ListItem>Who is your favorite actor</asp:ListItem>
                    <asp:ListItem>What is your favorite food</asp:ListItem>
                    <asp:ListItem>In what city were you born</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="ddsecurity" ErrorMessage="please select " InitialValue="--select--" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style15">Security Answer<span class="auto-style9">*</span></td>
            <td class="auto-style6">
                <asp:TextBox ID="txtsecurity" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtsecurity" ErrorMessage="please select answers" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">Proof<span class="auto-style9">*</span></td>
            <td>
                <asp:FileUpload ID="fileProof" runat="server" Width="305px" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="fileProof" ErrorMessage="Please Choose file" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">Logo<span class="auto-style9">*</span></td>
            <td>
                <asp:FileUpload ID="fileLogo" runat="server" Width="305px" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="fileLogo" ErrorMessage="Please Choose file" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" Width="80px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style18"></td>
            <td class="auto-style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style19"></td>
            <td class="auto-style4">
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style19"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

