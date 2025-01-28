<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AgencyRejectedList.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 24px;
        }
        .auto-style5 {
            height: 24px;
            width: 95px;
        }
        .auto-style6 {
            height: 26px;
            width: 95px;
        }
        .auto-style7 {
            width: 95px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                <asp:GridView ID="grdagencyrejected" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No Record" OnPageIndexChanging="grdagencyrejected_PageIndexChanging" PageSize="5" OnRowCommand="grdagencyrejected_RowCommand" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="agency_name" HeaderText="Agency Name" />
                        <asp:BoundField DataField="district_name" HeaderText="District" />
                        <asp:BoundField DataField="place_name" HeaderText="Place" />
                        <asp:BoundField DataField="agency_pincode" HeaderText="Pincode" />
                        <asp:BoundField DataField="agency_email" HeaderText="Email" />
                        <asp:BoundField DataField="agency_contact" HeaderText="Contact No" />
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
                        <asp:BoundField DataField="agency_regdate" HeaderText="Registration Date" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:TemplateField HeaderText="Accept">
                            <ItemTemplate>
                                <asp:Button ID="btnaccept" runat="server" CommandArgument='<%# Eval("agency_id") %>' CommandName="acp" Text="Accept" Width="80px" />
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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
               <%-- <asp:LinkButton ID="lbagreject" runat="server" OnClick="lbagreject_Click">Home</asp:LinkButton>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

