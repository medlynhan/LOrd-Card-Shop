<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="ManageCardPage.aspx.cs" Inherits="LOrd_Card_Shop.View.ManageCardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h1>Manage Card</h1></br>

    <asp:GridView ID="ManageCardGrid" runat="server" AutoGenerateColumns="False" OnRowDeleting="ManageCardGrid_RowDeleting" OnRowEditing="ManageCardGrid_RowEditing">   
        <Columns>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="Edit" runat="server" Text="Edit"  CommandName="Edit"/>
                    <asp:Button ID="Delete" runat="server" Text="Delete"  CommandName="Delete"/>
                </ItemTemplate>
            </asp:TemplateField>


            <asp:BoundField DataField="CardId" HeaderText="CardId" SortExpression="CardId" />
            <asp:BoundField DataField="CardName" HeaderText="CardName" SortExpression="CardName" />
            <asp:BoundField DataField="CardPrice" HeaderText="CardPrice" SortExpression="CardPrice"/>
            <asp:BoundField DataField="CardDesc" HeaderText="CardDesc" SortExpression="CardDesc" />
            <asp:BoundField DataField="CardType" HeaderText="CardType" SortExpression="CardType" />
            <asp:BoundField DataField="isFoil" HeaderText="isFoil" SortExpression="isFoil" />


        </Columns>

    </asp:GridView><br/>

    <asp:Button ID="InsertBtn" runat="server" Text="Insert Data"  OnClick="InsertBtn_Click"/><br/>
        <asp:Label ID="ErrorMsg" runat="server" Text=" "></asp:Label>
</div>
</asp:Content>
