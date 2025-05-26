<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="LOrd_Card_Shop.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h1>Cart Page</h1>
            <br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ShowName" HeaderText="Show Name" SortExpression="ShowName"></asp:BoundField>
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"></asp:BoundField>
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description"></asp:BoundField>
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
                </Columns>


            </asp:GridView>
            <br />
            <asp:Button ID="ClearBtn" runat="server" Text="Clear Card" OnClick="ClearBtn_Click"/>

            <br />
            <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" OnClick="CheckoutBtn_Click" />


        </div>

</asp:Content>
