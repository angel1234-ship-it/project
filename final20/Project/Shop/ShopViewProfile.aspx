<%@ Page Title="" Language="C#" MasterPageFile="~/Shop/ShopMaster.master" AutoEventWireup="true" CodeFile="ShopViewProfile.aspx.cs" Inherits="Shop_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 203px;
        }
        .auto-style3 {
            width: 203px;
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
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:DetailsView ID="dvshopview" runat="server" AutoGenerateRows="False" CellPadding="4" Height="50px" Width="125px" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                    <EditRowStyle BackColor="#999999" />
                    <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                    <Fields>
                        <asp:TemplateField>
                            <ItemTemplate>
                               <img src="../Assests/ShopDocs/<%#Eval("shop_photo") %>" width="100"height="100" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="shop_name" HeaderText="Shop Name" />
                        <asp:BoundField DataField="shop_ownername" HeaderText="Owner Name" />
                        <asp:BoundField DataField="district_name" HeaderText="District" />
                        <asp:BoundField DataField="place_name" HeaderText="place" />
                        <asp:BoundField DataField="shop_email" HeaderText="Email" />
                        <asp:BoundField DataField="shop_contact" HeaderText="Contact No" />
                        <asp:BoundField DataField="shop_address" HeaderText="Address" />
                      <%--  <asp:TemplateField HeaderText="ID Proof">
                            <ItemTemplate>
                                <img src="../Assests/ShopDocs/<%#Eval("shop_proof") %>" width="100"height="100" />
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                    </Fields>
                    <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                </asp:DetailsView>
            &nbsp;&nbsp;
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
              <%--  <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Home</asp:LinkButton>--%>
            </td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
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

