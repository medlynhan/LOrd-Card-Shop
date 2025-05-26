<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="AddCardPage.aspx.cs" Inherits="LOrd_Card_Shop.View.AddCardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Add Card</h1><br />
        <asp:Label ID="Label1" runat="server" Text="Card Name"></asp:Label><br />
        <asp:TextBox ID="CardNameTb" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Card Price"></asp:Label><br />
        <asp:TextBox ID="CardPriceTb" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label3" runat="server" Text="Card Description" TextMode="MultiLine"></asp:Label><br />
        <asp:TextBox ID="CardDescTb" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label4" runat="server" Text="Card Type"></asp:Label><br />
        <asp:TextBox ID="CardTypeTb" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label5" runat="server" Text="Is Foil"></asp:Label><br />
        <asp:TextBox ID="IsFoilTb" runat="server"></asp:TextBox><br />

        <br />
        <asp:Label ID="ErrorMsg" runat="server" Text=" " ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="AddCardBtn" runat="server" Text="Add Card" OnClick="AddCardBtn_Click" />
    </div>
</asp:Content>
