﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Farmer/PaymentMethod/PayMaster.master" AutoEventWireup="true" CodeFile="ThirdPage.aspx.cs" Inherits="Farmer_PaymentMethod_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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

            .auto-style21 {
                height: 86px;
                text-align: center;
                width: 610px;
            }
            .auto-style22 {
                width: 610px;
            }
            .auto-style23 {
                height: 86px;
                text-align: center;
                width: 728px;
            }
            .auto-style24 {
                width: 728px;
            }

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <table class="auto-style1">
        <tr>
            <td class="auto-style23"></td>
            <td class="auto-style19">
                <img alt="" class="auto-style20" src="Images/loading.gif" /></td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td style="text-align: center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <img alt="" class="auto-style18" src="Images/Process1.JPG" /></td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" Interval="120" OnTick="Timer1_Tick">
                        </asp:Timer>
                    </ContentTemplate>
                </asp:UpdatePanel>
                &nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

