<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="CheckoutPage.aspx.cs" Inherits="LOrd_Card_Shop.View.CheckoutPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h1>Checkout Page</h1>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ShowName" HeaderText="Show Name" SortExpression="ShowName"></asp:BoundField>
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"></asp:BoundField>
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description"></asp:BoundField>
                    <asp:BoundField DataField="TotalPrice" HeaderText="Total Price" SortExpression="TotalPrice"></asp:BoundField>
                </Columns>


            </asp:GridView>
            <br />

            <asp:Label ID="Label1" runat="server" Text="Total: $ "></asp:Label><asp:Label ID="TotalPriceLbl" runat="server" Text=" "></asp:Label>

            <br />

            <asp:Button ID="CheckoutNowBtn" runat="server" Text="Checkout Now" OnClick="CheckoutNowBtn_Click" />
            



        </div>
</asp:Content>
