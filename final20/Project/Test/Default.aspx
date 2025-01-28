<%@ Page Title="" Language="C#" MasterPageFile="~/Test/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Test_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="printDiv">
    <table class="auto-style1">
        <tr>
            <td>SL.No</td>
            <td>Name</td>
            <td>Contact</td>
            <td>Address</td>
        </tr>
        <tr>
            <td>1</td>
            <td>Suraj</td>
            <td>81295944852</td>
            <td>Thodupuzha</td>
        </tr>
        <tr>
            <td>2</td>
            <td>Abi</td>
            <td>9888535333</td>
            <td>Muvattupuzha</td>
        </tr>
        <tr>
            <td>3</td>
            <td>Nandu</td>
            <td>766167/4414</td>
            <td>Muvattupuzha</td>
        </tr>
    </table>
        </div>
    <button onclick="printFunction()">Print</button>
    
</asp:Content>
