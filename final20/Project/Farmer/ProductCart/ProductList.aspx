<%@ Page Title="" Language="C#" MasterPageFile="~/Farmer/ProductCart/ProductCart.master" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="Farmer_ProductCart_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style type="text/css">

       .ratingStar
        {
            font-size: 0pt;
            width: 13px;
            height: 12px;
            margin: 0px;
            padding: 0px;
            cursor: pointer;
            display: block;
            background-repeat: no-repeat;
        }
        
        .filledRatingStar
        {
            background-image: url(RatingImages/FilledStar.png);
        }
        
        .emptyRatingStar
        {
            background-image: url(RatingImages/EmptyStar.png);
        }
        
        .savedRatingStar
        {
            background-image: url(RatingImages/SavedStar.png);
        }


         .bak {
             background-color:blue;
             opacity:0.3;
             filter:alpha(opacity=30);

         }
         .image22 {
             flex-align:center;
             position:fixed;
         }
            .auto-style9 {
                width: 100%;
            }
            .auto-style10 {
                width: 196px;
            }
        .auto-style11 {
        width: 196px;
        height: 55px;
    }
    .auto-style12 {
        height: 55px;
    }
    .auto-style13 {
        width: 196px;
        height: 27px;
    }
    .auto-style14 {
        height: 27px;
    }
            .auto-style15 {
                height: 32px;
            }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style9">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style15"></td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Select Type:<asp:DropDownList ID="ddtype" runat="server" Width="300px" OnSelectedIndexChanged="ddtype_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddtype" ErrorMessage="please select" InitialValue="--select--" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:DataList ID="datalistcart" runat="server" CellPadding="4" ForeColor="#333333" OnItemCommand="datalistcart_ItemCommand">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="auto-style9">
                            <tr>
                              
                                <td><img src="../../Assests/ShopDocs/<%#Eval("shopproduct_photo") %>" width="100" height="100" /></td>
                            </tr>
                            <tr>
                                <td>Product:<asp:Label ID="Label1" runat="server" Text='<%# Eval("shopproduct_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Type:
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("type_name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Price:
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("shopproduct_price") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btncart" runat="server" CommandArgument='<%# Eval("shopproduct_id") %>' CommandName="cart" style="margin-left: 18px" Text="Add to Cart" Width="250px" CausesValidation="False" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("shopproduct_id") %>' CommandName="com" CausesValidation="False">Comment</asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Panel ID="cartpanel" runat="server">
                    <table class="auto-style9">
                        <tr>
                            <td class="auto-style11">Comment</td>
                            <td class="auto-style12">
                                <asp:TextBox ID="txtcomment" runat="server" Height="40px" Width="300px" AutoPostBack="True"></asp:TextBox>
                                &nbsp;<asp:Button ID="btnpost" runat="server" Text="Post" Width="100px" OnClick="btnpost_Click" />
                                <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="100px" OnClick="btncancel_Click" CausesValidation="False" />
                            </td>
                            <td class="auto-style12"></td>
                        </tr>
                        <tr>
                            <td class="auto-style13"></td>
                            <td class="auto-style14">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcomment" ErrorMessage="please add comments" style="color: #FF0000"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style14"></td>
                        </tr>
                        <tr>
                            <td class="auto-style10">&nbsp;</td>
                            <td>
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" PageSize="5">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <table class="style1">
                                                    <tr>
                                                        <td class="auto-style15" colspan="4">
                                                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("comment_description") %>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style20">By :</td>
                                                        <td class="auto-style16">
                                                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("farmer_name") %>'></asp:Label>
                                                        </td>
                                                        <td class="auto-style21">Date</td>
                                                        <td>
                                                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("comment_date") %>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <EditRowStyle BackColor="#999999" />
                                    <EmptyDataTemplate>
                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style15" colspan="4">
                                                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style15">Posted By :Posted By :</td>
                                                <td class="auto-style16">
                                                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                                                </td>
                                                <td>Date</td>
                                                <td>
                                                    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </EmptyDataTemplate>
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
                            <td class="auto-style10">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">&nbsp;</td>
                            <td>
                                <asp:HiddenField ID="HiddenField1" runat="server" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

