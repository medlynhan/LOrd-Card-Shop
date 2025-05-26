<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LOrd_Card_Shop.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="welcomeUser">
        <h1>Welcome, 
            <asp:Label ID="UsernameLbl" runat="server" Text=" "></asp:Label>
            !</h1>
    </div>
</asp:Content>
