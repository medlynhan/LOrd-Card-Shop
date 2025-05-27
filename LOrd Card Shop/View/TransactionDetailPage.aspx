<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="LOrd_Card_Shop.View.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Transaction Detail</h1>


        <asp:GridView ID="TransactionDetailGrid" runat="server" AutoGenerateColumns="False" >   
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="CardId" HeaderText="CardId" SortExpression="CardId" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"/>
            </Columns>

        </asp:GridView><br/>

        <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click"/>
    </div>
</asp:Content>
