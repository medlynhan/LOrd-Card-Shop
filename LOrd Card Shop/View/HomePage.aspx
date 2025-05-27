<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LOrd_Card_Shop.View.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="welcomeUser">
        <h1>Welcome, 
            <asp:Label ID="UsernameLbl" runat="server" Text=" "></asp:Label>
            !</h1>
    </div>
    <%--<asp:Label ID="debugText" runat="server" Text=""></asp:Label>--%>
     <div>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="CardName" HeaderText="Name" SortExpression="CardName" />
                 <asp:BoundField DataField="CardPrice" HeaderText="Price" SortExpression="CardPrice" />
                 <asp:BoundField DataField="CardDesc" HeaderText="Desc" SortExpression="CardDesc" />
             </Columns>
         </asp:GridView>
    </div>
</asp:Content>