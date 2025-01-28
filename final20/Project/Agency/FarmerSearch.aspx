<%@ Page Title="" Language="C#" MasterPageFile="~/Agency/AgencyMaster.master" AutoEventWireup="true" CodeFile="FarmerSearch.aspx.cs" Inherits="Agency_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 441px;
        }
        .auto-style3 {
            width: 441px;
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
            <td class="auto-style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; District:
                <asp:DropDownList ID="dddistrict" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dddistrict_SelectedIndexChanged" Width="300px">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>Place:<asp:DropDownList ID="ddplace" runat="server" AutoPostBack="True" Width="300px" OnSelectedIndexChanged="ddplace_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <br />
                <br />
                <asp:DataList ID="datalistfarmer" runat="server" CellPadding="4" ForeColor="#333333" OnItemCommand="datalistfarmer_ItemCommand">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                                <td> <img src="../Assests/FarmerDocs/<%#Eval("farmer_photo") %>" width="150" height="100" />  </td>
                            </tr>
                            <tr>
                                <td>
                                    Name:</td>
                                <td>
                                    <asp:Label ID="lbname" runat="server" Text='<%# Eval("farmer_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Place:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblplace" runat="server" Text='<%# Eval("place_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="btnview" runat="server" CommandArgument='<%# Eval("farmer_id") %>' CommandName="vm" style="margin-left: 32px" Text="ViewMore" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

