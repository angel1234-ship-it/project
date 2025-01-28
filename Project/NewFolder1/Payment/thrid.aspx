<%@ Page Title="" Language="C#" MasterPageFile="~/NewFolder1/Payment/pay.Master" AutoEventWireup="true" CodeBehind="thrid.aspx.cs" Inherits="MusicalInstruments.User.Payment.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style19 {
            height: 86px;
            text-align: center;
        }

        .auto-style20 {
            width: 114px;
            height: 139px;
        }
        .auto-style18 {
            width: 697px;
            height: 322px;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style19"></td>
            <td class="auto-style19">
                <img alt="" class="auto-style20" src="Images/loading.gif" /></td>
            <td class="auto-style19"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align: center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <img alt="" class="auto-style18" src="Images/Process1.JPG" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                        </asp:Timer>
                    </ContentTemplate>
                </asp:UpdatePanel>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
