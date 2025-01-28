﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Farmer/FarmerMaster.master" AutoEventWireup="true" CodeFile="ItemOrderView.aspx.cs" Inherits="Farmer_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 139px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:GridView ID="Grdshop" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" EmptyDataText="NoOrders" OnPageIndexChanging="Grdshop_PageIndexChanging" OnRowCommand="Grdshop_RowCommand" PageSize="5">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <img src="../Assests/ShopDocs/<%#Eval("shopproduct_photo") %>" width="150" height="100" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="subtype_name" HeaderText="Product" />
                        <asp:BoundField DataField="shopproduct_name" HeaderText="Product Name" />
                        <asp:BoundField DataField="productbooking_quantity" HeaderText="Order in Kg/Count" />
                        <asp:BoundField DataField="productbooking_amount" HeaderText="Amount" />
                        <asp:BoundField DataField="productbooking_date" HeaderText="Booking Date" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btndelete" runat="server" CommandArgument='<%# Eval("productbooking_id") %>' CommandName="del" Text="Remove" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnpay" runat="server" CommandArgument='<%# Eval("productbooking_id") %>' CommandName="pay" Text="PayNow" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

