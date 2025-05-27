<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="LOrd_Card_Shop.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h1>Cart Page</h1>
            <br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="CardName" HeaderText="ShowName" SortExpression="CardName"></asp:BoundField>
                    <asp:BoundField DataField="CardPrice" HeaderText="Price" SortExpression="CardPrice"></asp:BoundField>
                    <asp:BoundField DataField="CardDesc" HeaderText="Description" SortExpression="CardDesc"></asp:BoundField>
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
                </Columns>


            </asp:GridView>
            <br />
            <asp:Button ID="ClearBtn" runat="server" Text="Clear Card" OnClick="ClearBtn_Click"/>

            <br /><br />
            <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" OnClick="CheckoutBtn_Click" />


        </div>

</asp:Content>
