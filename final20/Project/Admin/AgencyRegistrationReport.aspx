<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AgencyRegistrationReport.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .print-gridview {
            display: block; /* Ensure grid displays even if hidden on screen */
            page-break-after: always; /* Start each page on a new sheet */
            border: 1px solid #ddd;
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 73px;
        }

        .auto-style19 {
            height: 33px;
            width: 990px;
        }

        .auto-style3 {
            color: #FF0000;
        }

        .auto-style27 {
            width: 19px;
        }

        .auto-style28 {
            width: 16px;
        }

        .auto-style29 {
            width: 122px;
        }

        .auto-style30 {
            width: 1191px;
        }

        .auto-style32 {
            height: 26px;
            width: 990px;
        }

        .auto-style34 {
            width: 559px;
        }

        .auto-style35 {
            height: 29px;
        }

        .auto-style37 {
            height: 29px;
            width: 131px;
        }

        .auto-style38 {
            width: 131px;
        }

        .auto-style40 {
            height: 29px;
            width: 13px;
        }

        .auto-style41 {
            width: 13px;
        }

        .auto-style44 {
            width: 296px;
        }

        .auto-style46 {
            width: 927px;
        }

        .auto-style48 {
            color: #FF3300;
        }

        .auto-style49 {
            width: 104px;
        }

        .auto-style50 {
            width: 195px;
        }

        .auto-style52 {
            width: 114px;
        }

        .auto-style53 {
            width: 117px;
        }
        .auto-style54 {
            width: 195px;
            height: 29px;
        }
        .auto-style55 {
            width: 128px;
            height: 29px;
        }
        .auto-style56 {
            width: 128px;
        }
        .auto-style57 {
            width: 145px;
        }
        .auto-style58 {
            height: 29px;
            width: 145px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style30">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style30">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style30">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style30">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style32">
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="LinkButton1_Click">AgencyRegistrationReport</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" OnClick="LinkButton2_Click">AgencySubscription</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" CausesValidation="False">FarmerRegistration</asp:LinkButton>
                            &nbsp;&nbsp;
                            <asp:LinkButton ID="LinkButton4" runat="server" CausesValidation="False" OnClick="LinkButton4_Click">FarmerSubscription</asp:LinkButton>
                            &nbsp;&nbsp;
                            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" CausesValidation="False">ShopRegistartion</asp:LinkButton>
                            &nbsp;&nbsp;
                            <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click" CausesValidation="False">ShopSubscription</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19">
                            <asp:MultiView ID="MultiView1" runat="server">
                                <asp:View ID="View1" runat="server">
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">From Date<span class="auto-style3">*</span></td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">
                                                <asp:TextBox ID="txtdate" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtdate" ErrorMessage="please enter from date" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">
                                                <asp:Label ID="Label1" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">To Date<span class="auto-style3">* </span></td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">
                                                <asp:TextBox ID="txttodate" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txttodate" ErrorMessage="please enter todate" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">
                                                <asp:Label ID="Label2" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">
                                                <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click1" Text="Report" Width="89px" />
                                              <%--  <asp:Button ID="btnpdf" runat="server" Text="Print" />--%>
                                                   <button onclick="printFunction5()">Print</button>
                                            </td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">
                                                <asp:Literal ID="Literalsearch" runat="server"></asp:Literal>
                                            </td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td id="printDiv5" class="auto-style46">
                                                <asp:GridView ID="grdagency" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                    <Columns>
                                                        <asp:BoundField DataField="agency_id" HeaderText="Reg ID" />
                                                        <asp:BoundField DataField="agency_name" HeaderText="Agency " />
                                                        <asp:BoundField DataField="agency_address" HeaderText="Address" />
                                                        <asp:BoundField DataField="agency_address" HeaderText="Email" />
                                                        <asp:BoundField DataField="agency_contact" HeaderText="Contact No" />
                                                        <asp:BoundField DataField="agency_regdate" HeaderText="Registration Date" DataFormatString="{0:dd/MM/yyyy}" />
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
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style27">&nbsp;</td>
                                            <td class="auto-style44">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style30">&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:View>
                                <asp:View ID="View2" runat="server">
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">From Date<span class="auto-style3">*</span></td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">
                                                <asp:TextBox ID="txtdate1" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtdate1" ErrorMessage="please enter from date" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">
                                                <asp:Label ID="Label3" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">To Date<span class="auto-style3">* </span></td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">
                                                <asp:TextBox ID="txttodate1" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txttodate1" ErrorMessage="please enter todate" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">
                                                <asp:Label ID="Label4" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">
                                                <asp:Button ID="btnsearch1" runat="server" OnClick="btnsearch1_Click" Text="Search" />
                                                <%--   <asp:Button ID="btnpdf1" runat="server" Text="Export to Excel" OnClick="btnpdf1_Click" />--%>
                                                <%--<asp:Button ID="btnPrint1" runat="server" OnClick="btnPrint1_Click" Text="Export to PDF" />--%>
                                               <%-- <asp:Button ID="btnnew" runat="server" OnClick="btnnew_Click" Text="Button" />--%>
                                                   <button onclick="printFunction4()">Print</button>
                                            </td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td  id="printDiv4" class="auto-style34">
                                                <asp:GridView ID="grdsubscription" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="grdsubscription_PageIndexChanging" Width="569px">
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                    <Columns>
                                                        <asp:BoundField DataField="subpayment_id" HeaderText="Subscription ID" />
                                                        <asp:BoundField DataField="agency_name" HeaderText="Name" />
                                                        <asp:BoundField DataField="agency_address" HeaderText="Address" />
                                                        <asp:BoundField DataField="agency_contact" HeaderText="Contact No" />
                                                        <asp:BoundField DataField="subpayment_date" HeaderText="Subscription Date" DataFormatString="{0:dd/MM/yyyy}" />
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
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style28">&nbsp;</td>
                                            <td class="auto-style29">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td class="auto-style34">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:View>
                                <asp:View ID="View3" runat="server">
                                    <table class="w-100">
                                        <tr>
                                            <td class="auto-style38">From Date<span class="auto-style3">*</span></td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>
                                                <asp:TextBox ID="txtdate2" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtdate2" ErrorMessage="please enter from date" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label5" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style37">To Date<span class="auto-style3">*</span></td>
                                            <td class="auto-style40">&nbsp;</td>
                                            <td class="auto-style35">
                                                <asp:TextBox ID="txttodate2" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txttodate2" ErrorMessage="please enter to date" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                            <td class="auto-style35"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label6" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="btnsearch2" runat="server" OnClick="btnsearch2_Click" Text="Report" />
                                               <%-- <asp:Button ID="btnpdf2" runat="server" Text="Report to PDF" />--%>
                                                 <button onclick="printFunction3()">Print</button>

                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td id ="printDiv3">
                                                <asp:GridView ID="grdfarmer1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="grdfarmer1_PageIndexChanging" Width="564px" OnSelectedIndexChanged="grdfarmer1_SelectedIndexChanged">
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                    <Columns>
                                                        <asp:BoundField DataField="farmer_id" HeaderText="RegID" />
                                                        <asp:BoundField DataField="farmer_name" HeaderText="Name" />
                                                        <asp:BoundField DataField="farmer_address" HeaderText="Address" />
                                                        <asp:BoundField DataField="farmer_contact" HeaderText="Contact No" />
                                                        <asp:BoundField DataField="farmer_regdate" HeaderText="Registration Date" DataFormatString="{0:dd/MM/yyyy}" />
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
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style38">&nbsp;</td>
                                            <td class="auto-style41">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:View>
                                <asp:View ID="View4" runat="server">
                                    <table class="w-100">
                                        <tr>
                                            <td class="auto-style49">From Date<span class="auto-style48">*</span></td>
                                            <td>
                                                <asp:TextBox ID="txtdate3" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtdate3" ErrorMessage="please enter from date" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label7" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">To Date<span class="auto-style3">*</span></td>
                                            <td>
                                                <asp:TextBox ID="txttodate3" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txttodate3" ErrorMessage="please enter to date" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label8" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="btnsearch4" runat="server" OnClick="btnsearch4_Click" Text="Report" />
                                              <%--  <asp:Button ID="btnreport" runat="server" Text="Report to PDF" />--%>
                                                    <button onclick="printFunction2()">Print</button>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td id="printDiv2">
                                                <asp:GridView ID="grdsubview" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="grdsubview_PageIndexChanging" Width="616px">
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                    <Columns>
                                                        <asp:BoundField DataField="subpayment_id" HeaderText="Subscription ID" />
                                                        <asp:BoundField DataField="farmer_name" HeaderText="Name" />
                                                        <asp:BoundField DataField="farmer_address" HeaderText="Address" />
                                                        <asp:BoundField DataField="farmer_contact" HeaderText="Contact No" />
                                                        <asp:BoundField DataField="subpayment_date" HeaderText="Subscription Date" DataFormatString="{0:dd/MM/yyyy}" />
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
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style49">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:View>
                                <asp:View ID="View5" runat="server">
                                    <table class="w-100">
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">From Date<span class="auto-style3">*</span></td>
                                            <td>
                                                <asp:TextBox ID="txtshopfdate" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtshopfdate" ErrorMessage="please enter from date" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label9" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">To Date<span class="auto-style3">*</span></td>
                                            <td>
                                                <asp:TextBox ID="txtshoptdate" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtshoptdate" ErrorMessage="please enter todate" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label10" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="btnshopreport" runat="server" OnClick="btnshopreport_Click" Text="Report" />
                                                <%--<asp:Button ID="btnexportpdf" runat="server" OnClick=" "Text="Export to PDF" />--%>
                                                <button onclick="printFunction()">Print</button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style54"></td>
                                            <td class="auto-style55">&nbsp;</td>
                                            <td class="auto-style58"></td>
                                            <td class="auto-style35">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td id="printDiv">
                                                <asp:GridView ID="grdshopreg" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="grdshopreg_PageIndexChanging" Width="546px">
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                    <Columns>
                                                        <asp:BoundField DataField="shop_id" HeaderText="Reg ID " />
                                                        <asp:BoundField DataField="shop_name" HeaderText="Shop" />
                                                        <asp:BoundField DataField="shop_address" HeaderText="Address" />
                                                        <asp:BoundField DataField="shop_contact" HeaderText="Contact No" />
                                                        <asp:BoundField DataField="shop_email" HeaderText="Email" />
                                                        <asp:BoundField DataField="shop_regdate" HeaderText="Registration Date" DataFormatString="{0:dd/MM/yyyy}" />
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
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style50">&nbsp;</td>
                                            <td class="auto-style56">&nbsp;</td>
                                            <td class="auto-style57">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:View>
                                <asp:View ID="View6" runat="server">
                                    <table class="w-100">
                                        <tr>
                                            <td class="auto-style52">&nbsp;</td>
                                            <td class="auto-style53">From Date<span class="auto-style3">*</span></td>
                                            <td>
                                                <asp:TextBox ID="txtshopdatef" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtshopdatef" ErrorMessage="please enter from date" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style52">&nbsp;</td>
                                            <td class="auto-style53">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label11" runat="server" Text="[yyyy/mm/dd]"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style52">&nbsp;</td>
                                            <td class="auto-style53">To Date<span class="auto-style3">*</span></td>
                                            <td>
                                                <asp:TextBox ID="txtshopdatet" runat="server" Width="300px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtshopdatet" ErrorMessage="please enter to date" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style52">&nbsp;</td>
                                            <td class="auto-style53">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label12" runat="server" Text="[yyyyy/mm/dd]"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style52">&nbsp;</td>
                                            <td class="auto-style53">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="btnfinalreport" runat="server" OnClick="btnfinalreport_Click" Text="Report" />
                                         <%--       <asp:Button ID="btnfinalpdf" OnClick="printGridView()" Text="Export to PDF" />--%>
                                                <%--<asp:Button ID="btnPrint0" runat="server" OnClick="btnPrint_Click" Text="Print Grid View" />--%>
                                                <button onclick="printFunction1()">Print</button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style52">&nbsp;</td>
                                            <td class="auto-style53">&nbsp;</td>
                                            <td>
                                                <table class="w-100">
                                                    <tr>
                                                        <td></td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td id ="printDiv1">
                                                            
                                                            <asp:GridView ID="grdsubshop" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="grdsubshop_PageIndexChanging" Width="673px">
                                                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                                <Columns>
                                                                    <asp:BoundField DataField="subpayment_id" HeaderText="Subscription ID" />
                                                                    <asp:BoundField DataField="shop_name" HeaderText="Shop" />
                                                                    <asp:BoundField DataField="shop_address" HeaderText="Address" />
                                                                    <asp:BoundField DataField="shop_contact" HeaderText="Contact No" />
                                                                    <asp:BoundField DataField="shop_email" HeaderText="Email" />
                                                                    <asp:BoundField DataField="subpayment_date" HeaderText="Subscription Date" DataFormatString="{0:dd/MM/yyyy}" />
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
                                                        <td>&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style52">&nbsp;</td>
                                            <td class="auto-style53">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:View>
                            </asp:MultiView>
                        </td>
                    </tr>
                   
                </table>
            </td>
        </tr>
        
    </table>
  <script>
      function  printFunction() {
          var printContents = document.getElementById("printDiv").innerHTML;
          var orginalContents = document.body.innerHTML;
          document.body.innerHTML = printContents;
          window.print();
          document.body.innerHTML = orginalContents;

      }
     

      function printFunction1() {
          var printContents = document.getElementById("printDiv1").innerHTML;
          var orginalContents = document.body.innerHTML;
          document.body.innerHTML = printContents;
          window.print();
          document.body.innerHTML = orginalContents;

      }
      function printFunction2() {
          var printContents = document.getElementById("printDiv2").innerHTML;
          var orginalContents = document.body.innerHTML;
          document.body.innerHTML = printContents;
          window.print();
          document.body.innerHTML = orginalContents;

      }
      function printFunction3() {
          var printContents = document.getElementById("printDiv3").innerHTML;
          var orginalContents = document.body.innerHTML;
          document.body.innerHTML = printContents;
          window.print();
          document.body.innerHTML = orginalContents;

      }
      function printFunction4() {
          var printContents = document.getElementById("printDiv4").innerHTML;
          var orginalContents = document.body.innerHTML;
          document.body.innerHTML = printContents;
          window.print();
          document.body.innerHTML = orginalContents;

      }
      function printFunction5() {
          var printContents = document.getElementById("printDiv5").innerHTML;
          var orginalContents = document.body.innerHTML;
          document.body.innerHTML = printContents;
          window.print();
          document.body.innerHTML = orginalContents;

      }
</script>
</asp:Content>



