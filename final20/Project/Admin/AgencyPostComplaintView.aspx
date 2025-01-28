<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AgencyPostComplaintView.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 59px;
        }
        .auto-style3 {
            width: 59px;
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
            <td class="auto-style3"></td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">NewComplaints</asp:LinkButton>
&nbsp;
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">SolvedComplaints</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <br />
                        <asp:GridView ID="grdagency" runat="server" AutoGenerateColumns="False" CellPadding="4" OnRowCommand="grdagency_RowCommand" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="complaint_title" HeaderText="Title" />
                                <asp:BoundField DataField="complaint_content" HeaderText="Complaint" />
                                <asp:BoundField DataField="complaint_date" HeaderText="complaint Date" DataFormatString="{0:dd/MM/yyyy}" />
                                <asp:BoundField DataField="agency_name" HeaderText="Agency" />
                                <asp:BoundField DataField="agency_address" HeaderText="Address" />
                                <asp:BoundField DataField="agency_contact" HeaderText="Contact No" />
                                <asp:TemplateField HeaderText="Reply">
                                    <ItemTemplate>
                                        <asp:Button ID="btnreply" runat="server" CommandArgument='<%# Eval("complaint_id") %>' CommandName="reply" Text="Reply" Width="80px" />
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
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                    </asp:View>
                </asp:MultiView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:GridView ID="grdagencysolved" runat="server" AutoGenerateColumns="False" CellPadding="4" OnRowCommand="grdagency_RowCommand" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="complaint_title" HeaderText="Title" />
                        <asp:BoundField DataField="complaint_content" HeaderText="Complaint" />
                        <asp:BoundField DataField="complaint_date" HeaderText="complaint Date" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:BoundField DataField="complaint_reply" HeaderText="Complaint Reply" />
                        <asp:BoundField DataField="complaint_replydate" HeaderText="Complaint Reply Date" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:BoundField DataField="agency_name" HeaderText="Agency" />
                        <asp:BoundField DataField="agency_address" HeaderText="Address" />
                        <asp:BoundField DataField="agency_contact" HeaderText="Contact No" />
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
    </table>
</asp:Content>

