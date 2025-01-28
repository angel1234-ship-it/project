<%@ Page Title="" Language="C#" MasterPageFile="~/Farmer/SubscriptionPayment/SubscriptionMaster.master" AutoEventWireup="true" CodeFile="FifthPaymentPage.aspx.cs" Inherits="Farmer_SubscriptionPayment_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <style type="text/css">

        .auto-style29 {
            height: 55px;
        }
        .auto-style18 {
            height: 35px;
        }
        .auto-style30 {
               text-align: right;
               font-weight: 700;
               width: 484px;
               height: 29px;
           }
        .auto-style31 {
            width: 15px;
            height: 29px;
        }
        .auto-style32 {
            height: 29px;
        }
        .auto-style33 {
            text-align: right;
            font-weight: 700;
            width: 484px;
            height: 30px;
        }
        .auto-style34 {
            width: 15px;
            height: 30px;
        }
        .auto-style35 {
            height: 30px;
        }
        .auto-style36 {
               text-align: right;
               font-weight: 700;
               width: 484px;
               height: 32px;
           }
        .auto-style37 {
            width: 15px;
            height: 32px;
        }
        .auto-style38 {
            height: 32px;
        }
        .auto-style21 {
            height: 39px;
        }
        .auto-style39 {
            height: 108px;
        }
        .auto-style24 {
            width: 50px;
            height: 30px;
        }
           .auto-style40 {
               height: 55px;
               width: 1122px;
           }
           .auto-style41 {
               height: 35px;
               width: 1122px;
           }
           .auto-style42 {
               width: 1122px;
           }
           .auto-style43 {
               height: 108px;
               width: 1122px;
           }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="printablediv">
        <fieldset>
            <legend style="text-align: center; font-weight: 700">Payment Details</legend>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style29"></td>
                    <td class="auto-style40" style="text-align: right">
                        <asp:LinkButton ID="LinkButton1" runat="server" Font-Underline="False" ForeColor="White" OnClientClick="JavaScript: printPartOfPage('printablediv');"> <img alt="" class="auto-style28" src="http://localhost:52330/User/Payment/Icons/1391813769_printer.png" /></asp:LinkButton>
                    </td>
                    <td class="auto-style29"></td>
                </tr>
                <tr>
                    <td class="auto-style18"></td>
                    <td class="auto-style41" style="text-align: center; color: #3399FF">Payment Success...</td>
                    <td class="auto-style18"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style42">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style31">&nbsp;</td>
                                <td class="auto-style32">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style31">&nbsp;</td>
                                <td class="auto-style32">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style31"></td>
                                <td class="auto-style32">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style33">Date</td>
                                <td class="auto-style34"></td>
                                <td class="auto-style35">&nbsp;<asp:Label ID="lblDate" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style36">Amount</td>
                                <td class="auto-style37"></td>
                                <td class="auto-style38">Rs.<asp:Label ID="lblAmoubnt" runat="server"></asp:Label>
                                    <strong>/-Credited</strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style36">&nbsp; Transaction ID</td>
                                <td class="auto-style37"></td>
                                <td class="auto-style38">&nbsp;
                                    <asp:Label ID="lblTID" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style21" colspan="3" style="text-align: center">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-weight: 700" Text="Continue" Width="110px" BackColor="Green" ForeColor="White"/>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39"></td>
                    <td class="auto-style43" style="text-align: center">&nbsp;&nbsp;&nbsp;
                        <img alt="" class="auto-style24" src="Icons/1391813453_mastercard1.gif" />
                        <img alt="" class="auto-style24" src="Icons/1391813456_visa2.gif" />
                        <img alt="" class="auto-style24" src="Icons/1391813466_westernunion.gif" />
                        <img alt="" class="auto-style24" src="Icons/1391813469_cirrus1.gif" />
                        <img alt="" class="auto-style24" src="Icons/1391813513_visa1.gif" /></td>
                    <td class="auto-style39"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style42">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style42">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style42">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style42">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style42">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style42">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style42">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style42">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </fieldset></div>
</asp:Content>

