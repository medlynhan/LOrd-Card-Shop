<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="CardDetailPage.aspx.cs" Inherits="LOrd_Card_Shop.View.CardDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <br /> <br />
            <h1>Card Detail Page</h1>
            <br />

        <asp:GridView ID="OrderCardGrid" runat="server" AutoGenerateColumns="False" >   
            <Columns>

                <asp:BoundField DataField="CardId" HeaderText="CardId" SortExpression="CardId" />
                <asp:BoundField DataField="CardName" HeaderText="CardName" SortExpression="CardName" />
                <asp:BoundField DataField="CardPrice" HeaderText="CardPrice" SortExpression="CardPrice" />
                <asp:BoundField DataField="CardDesc" HeaderText="CardDesc" SortExpression="CardDesc" />
                <asp:BoundField DataField="CardType" HeaderText="CardType" SortExpression="CardType" />
                <asp:BoundField DataField="isFoil" HeaderText="isFoil" SortExpression="isFoil" />


            </Columns>

        </asp:GridView><br/>
            <br />
            <asp:Button ID="BackBtn" runat="server" Text="Back" onclick ="BackBtn_Click"/>

        </div>

</asp:Content>
