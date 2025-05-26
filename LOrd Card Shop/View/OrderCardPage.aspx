<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderCardPage.aspx.cs" Inherits="LOrd_Card_Shop.View.OrderCardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <br />
    <h1>Order card</h1>

    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False" DataKeyNames="Id">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnAddToCart" runat="server" 
                    CommandName="AddToCart" 
                    CommandArgument='<%# Container.DataItemIndex %>'
                    Text="Add To Cart" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
                
    </asp:GridView>
    <br />
    <asp:Button ID="Detail" runat="server" Text="Card Detail Page" onclick="Detail_Click" /><br /><br />
</asp:Content>
