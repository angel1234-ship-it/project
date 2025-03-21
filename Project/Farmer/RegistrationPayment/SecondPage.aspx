﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Farmer/RegistrationPayment/RegistrationPayment.master" AutoEventWireup="true" CodeFile="SecondPage.aspx.cs" Inherits="Farmer_RegistrationPayment_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <style type="text/css">

        .auto-style57 {
            height: 82px;
            width: 316px;
        }
        .auto-style58 {
            height: 82px;
            width: 869px;
        }
        .auto-style27 {
            height: 36px;
            width: 145px;
        }
        .auto-style28 {
            height: 36px;
        }
        .auto-style25 {
            height: 33px;
            width: 145px;
        }
        .auto-style26 {
            height: 33px;
        }
        .auto-style62 {
            color: #00FF00;
        }
        .auto-style59 {
            height: 82px;
        }
        .auto-style35 {
            height: 98px;
            width: 316px;
        }
        .auto-style36 {
            height: 98px;
            width: 869px;
        }
        .auto-style33 {
            height: 31px;
            width: 143px;
        }
        .auto-style32 {
            height: 31px;
        }
        .auto-style34 {
            height: 33px;
            width: 143px;
        }
        .auto-style37 {
            height: 98px;
        }
        .auto-style38 {
            width: 316px;
            height: 49px;
        }
        .auto-style39 {
            width: 869px;
            height: 49px;
        }
        .auto-style41 {
            height: 59px;
        }
        .auto-style51 {
            width: 190px;
            height: 26px;
        }
        .auto-style52 {
            height: 26px;
        }
        .auto-style45 {
            width: 190px;
            height: 32px;
        }
        .auto-style53 {
            height: 32px;
        }
        .auto-style55 {
            height: 27px;
        }
        .auto-style56 {
            height: 30px;
        }
        .auto-style47 {
            height: 36px;
            text-align: center;
        }
        .auto-style50 {
            width: 694px;
        }
        .auto-style49 {
            width: 70px;
            height: 35px;
        }
        .auto-style48 {
            width: 63px;
            height: 35px;
        }
        .auto-style60 {
            height: 20px;
            text-align: center;
        }
        .auto-style61 {
            height: 46px;
            text-align: center;
        }
        .style2
        {
            color: #FF3300;
            height: 16px;
        }
        .auto-style40 {
            height: 49px;
        }
        .auto-style22 {
            width: 869px;
        }
        .auto-style63 {
            width: 316px;
        }
        </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <fieldset>
        <legend style="font-weight: 700; text-align: center; font-size: large">Transaction Details</legend>
        <table class="auto-style1">
            <tr>
                <td class="auto-style57"></td>
                <td class="auto-style58">
                    <fieldset>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style27">Pay To:</td>
                                <td class="auto-style28">
                                    <asp:Label ID="lbl_Payto" runat="server" ForeColor="#006600" style="font-weight: 700"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style25">Total Payable Amount:</td>
                                <td class="auto-style26">Rs.<asp:Label ID="lbl_Amount" runat="server" ForeColor="#006600" style="font-weight: 700" CssClass="auto-style62"></asp:Label>
                                    /-</td>
                            </tr>
                        </table>
                    </fieldset></td>
                <td class="auto-style59"></td>
            </tr>
            <tr>
                <td class="auto-style35"></td>
                <td class="auto-style36">
                    <fieldset>
                        <legend>Card Details</legend>
                        <table class="auto-style1">
                            <%--<tr>
                                <td class="auto-style33">Payment Method:</td>
                                <td class="auto-style32">Test Payment </td>
                            </tr>--%>
                            <tr>
                                <td class="auto-style34">Card Number:</td>
                                <td class="auto-style26">
                                    <asp:Label ID="lblCardNumber" runat="server" style="font-weight: 700"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </fieldset></td>
                <td class="auto-style37"></td>
            </tr>
            <tr>
                <td class="auto-style38"></td>
                <td class="auto-style39">
                    <fieldset>
                        <legend>Bill Details</legend>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style41">
                                    <p align="justify">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; The billing address is used to prevent fraud by matching it to your account information, enter this as close to the way it appears on your card statement
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td style="background-color: #99CCFF; text-align: center;"><b>If the billing address is given below.</b></td>
                            </tr>
                            <tr>
                                <td >
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style51">1. *Your Name</td>
                                            <td class="auto-style52" colspan="2">
                                                <asp:TextBox ID="txtName" runat="server" Width="300px" ReadOnly="True"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style45">2. *Address</td>
                                            <td class="auto-style53" colspan="2">
                                                <asp:TextBox ID="txtAddress" runat="server" Height="43px" TextMode="MultiLine" Width="300px" ReadOnly="True"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style55">3. *Email</td>
                                            <td class="auto-style55" colspan="2">
                                                <asp:TextBox ID="txtEmail" runat="server" Width="300px" ReadOnly="True"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style56">4. *Phone</td>
                                            <td class="auto-style56">
                                                <asp:TextBox ID="txtPhone" runat="server" Width="300px" ReadOnly="True"></asp:TextBox>
                                            </td>
                                            <td class="auto-style56">
                                                <asp:Button ID="Button1" runat="server" Text="Make Pyment" Width="144px"  style="font-weight: 700" OnClick="Button1_Click" BackColor="Green" ForeColor="White"/>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style47" colspan="3">
                                                <table class="auto-style1">
                                                    <tr>
                                                        <td class="auto-style50">
                                                            <p align="justify" style="color:#666666">
                                                                <b>&nbsp;&nbsp;&nbsp; In order to protect your card from fradulent transactions we might redirect you to partner site that will verify your card information. before we proceed with the payment </b>
                                                            </p>
                                                        </td>
                                                        <td>
                                                            <img alt="" class="auto-style49" src="Images/msc.gif" /></td>
                                                        <td>
                                                            <img alt="" class="auto-style48" src="Images/vbv.gif" /></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style60" colspan="3" style="background-color: #99CCFF"><em>*</em> denotes required field </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style61" colspan="3">
                                                <fieldset style="border-style:solid;border-color:#d4d0c8;">
                                                    <div>
                                                        <p class="style2">
                                                    The normal process time is approximately 5 seconds, however it may take longer at times.
                                                        </p>
                                                        <p class="style2">
                                                    Please wait for the intimation from the server, DO NOT press Back or Refresh button in order to avoid double charge.</p>
                                                    </div>
                                                </fieldset></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </fieldset></td>
                <td class="auto-style40"></td>
            </tr>
            <tr>
                <td class="auto-style63">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
          </fieldset> 
</asp:Content>

