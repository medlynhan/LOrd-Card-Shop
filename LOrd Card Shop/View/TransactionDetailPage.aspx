<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="LOrd_Card_Shop.View.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Transaction Detail</h1>

        <asp:Label ID="Label1" runat="server" Text="Transaction Id : "></asp:Label>
        <asp:Label ID="TransactionIdLbl" runat="server" Text=" "></asp:Label><br/>

        <asp:Label ID="Label2" runat="server" Text="Card Id : "></asp:Label>
        <asp:Label ID="CardIdLbl" runat="server" Text=" "></asp:Label><br/>

        <asp:Label ID="Label4" runat="server" Text="Quantity Id : "></asp:Label>
        <asp:Label ID="QuantityLbl" runat="server" Text=" "></asp:Label><br/>
        <br />
    </div>
</asp:Content>
