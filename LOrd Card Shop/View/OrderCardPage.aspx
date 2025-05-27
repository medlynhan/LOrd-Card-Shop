<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderCardPage.aspx.cs" Inherits="LOrd_Card_Shop.View.OrderCardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <br />
    <h1>Order card</h1>

    <asp:GridView ID="OrderCardGrid" runat="server" AutoGenerateColumns="False" OnRowEditing="OrderCardGrid_RowEditing">   
        <Columns>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="Edit" runat="server" Text="Add To Cart"  CommandName="Edit"/>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="CardId" HeaderText="CardId" SortExpression="CardId" />
            <asp:BoundField DataField="CardName" HeaderText="CardName" SortExpression="CardName" />
            <asp:BoundField DataField="CardPrice" HeaderText="CardPrice" SortExpression="CardPrice"/>


        </Columns>

    </asp:GridView><br/>
    <br />
    <asp:Button ID="Detail" runat="server" Text="Card Detail Page" onclick="Detail_Click" /><br /><br />
</asp:Content>
