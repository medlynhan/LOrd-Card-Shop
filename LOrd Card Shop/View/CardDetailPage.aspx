<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="CardDetailPage.aspx.cs" Inherits="LOrd_Card_Shop.View.CardDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <br /> <br />
            <h1>Card Detail Page</h1>
            <br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"></asp:BoundField>
                    <asp:BoundField DataField="CardType" HeaderText="Card Type" SortExpression="CardType"></asp:BoundField>
                    <asp:BoundField DataField="CardDesc" HeaderText="Card Description" SortExpression="CardDesc"></asp:BoundField>




                </Columns>



            </asp:GridView>
            <br />
            <asp:Button ID="BackBtn" runat="server" Text="Back" onclick ="BackBtn_Click"/>

        </div>

</asp:Content>
