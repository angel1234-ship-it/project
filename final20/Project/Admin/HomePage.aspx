<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 116px;
        }
        .auto-style3 {
            width: 116px;
            height: 114px;
        }
        .auto-style4 {
            height: 114px;
        }
        .auto-style5 {
            width: 116px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Welcome</td>
            <td>
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">District</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="lblplace" runat="server" OnClick="LinkButton2_Click" Width="150px">Place</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click">Category</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click">Type</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click">Subtype</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton12" runat="server" OnClick="LinkButton12_Click">RegistrationType</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton13" runat="server" OnClick="LinkButton13_Click">AgencySubscriptions</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click">AgencyNewList</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="lbagencyaccept" runat="server" OnClick="lbagencyaccept_Click">AgencyAcceptedList</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:LinkButton ID="lbagencyrejectlist" runat="server" OnClick="lbagencyrejectlist_Click">AgencyRejectedList</asp:LinkButton>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton17" runat="server" OnClick="LinkButton17_Click">FarmerSubscription</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="lbfarmerlist" runat="server" OnClick="lbfarmerlist_Click">FarmerNewList</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="lbfarmeraccept" runat="server" OnClick="lbfarmeraccept_Click">FarmerAcceptedList</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="lbfarmerreject" runat="server" OnClick="lbfarmerreject_Click">FarmerRejectedList</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton18" runat="server" OnClick="LinkButton18_Click">ShopSubscription</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="lbshoplist" runat="server" OnClick="lbshoplist_Click">ShopNewList</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="lbshopaccept" runat="server" OnClick="lbshopaccept_Click">ShopAcceptedList</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:LinkButton ID="lbshopreject" runat="server" OnClick="lbshopreject_Click">ShopRejectedList</asp:LinkButton>
                <br />
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click1">ViewProfile</asp:LinkButton>
                <br />
                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">EditProfile</asp:LinkButton>
                <br />
                <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">ChangePassword</asp:LinkButton>
                <br />
                <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">FarmerComplaintView</asp:LinkButton>
                <br />
               
            </td>
            <td class="auto-style4">
                <br />
                <br />
                <br />
                <br />
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">ShopCompalintsView</asp:LinkButton>
               
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click">AgencyComplaintView</asp:LinkButton>
               
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton14" runat="server" OnClick="LinkButton14_Click">AgenciesFeedbacks</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton15" runat="server" OnClick="LinkButton15_Click">FarmersFeedbacks</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton16" runat="server" OnClick="LinkButton16_Click">ShopsFeedbacks</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton19" runat="server" OnClick="LinkButton19_Click">AdminReport</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

