<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AgencyAcceptedList.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 689px;
        }
        .auto-style3 {
            height: 689px;
            width: 199px;
        }
        .auto-style4 {
            width: 199px;
        }
        .auto-style5 {
            width: 199px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            height: 689px;
            width: 875px;
        }
        .auto-style8 {
            width: 875px;
        }
        .auto-style9 {
            height: 26px;
            width: 875px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
            </td>
            <td class="auto-style7">
                <asp:GridView ID="grdagencyaccepted" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No Record" OnPageIndexChanging="grdagencyaccepted_PageIndexChanging" OnRowCommand="grdagencyaccepted_RowCommand" Height="364px" PageSize="5" Width="873px" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="agency_name" HeaderText="Agency Nmae" />
                        <asp:BoundField DataField="district_name" HeaderText="District" />
                        <asp:BoundField DataField="place_name" HeaderText="Place" />
                        <asp:BoundField DataField="agency_email" HeaderText="Email" />
                        <asp:BoundField DataField="agency_contact" HeaderText="Contact" />
                        <asp:BoundField DataField="agency_address" HeaderText="Address" />
                        <asp:TemplateField HeaderText="Logo">
                            <ItemTemplate>
                                <img src="../Assests/AgencyDocs/<%#Eval("agency_logo") %>" width="50" height="50" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID Proof">
                            <ItemTemplate>
                                <img src="../Assests/AgencyDocs/<%#Eval("agency_proof") %>" width="50" height="50" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Reject">
                            <ItemTemplate>
                                <asp:Button ID="btnreject" runat="server" CommandArgument='<%# Eval("agency_id") %>' CommandName="rej" Text="Reject" Width="80px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            &nbsp;&nbsp;
                <br />
                <br />
&nbsp;<asp:LinkButton ID="lbagaceept" runat="server" OnClick="lbagaceept_Click">Home</asp:LinkButton>
                <br />
            </td>
            <td class="auto-style2">
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

