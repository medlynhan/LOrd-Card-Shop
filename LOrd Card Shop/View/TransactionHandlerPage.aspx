<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHandlerPage.aspx.cs" Inherits="LOrd_Card_Shop.View.TransactionHandlerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div >
        <h1>Transaction Handler</h1>
        <asp:GridView ID="TransactionHandlerGrid" runat="server" AutoGenerateColumns="False" OnRowDeleting="TransactionHandlerGrid_RowDeleting" OnRowEditing="TransactionHandlerGrid_RowEditing">  
            <Columns>
                <asp:TemplateField HeaderText="Detail">
                    <ItemTemplate>
                        <asp:Button ID="Edit" runat="server" Text="Detail"  CommandName="Edit"/>
                    </ItemTemplate>
                </asp:TemplateField>
                   
                <asp:BoundField DataField="TransactionId" HeaderText="TransactionId" SortExpression="TransactionId" />
                <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
                <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                
                <asp:TemplateField HeaderText="Handle Transaction">
                    <ItemTemplate>
                        <asp:Button ID="Delete" runat="server" Text="Handle"  CommandName="Delete"/>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView><br/>

   </div>
</asp:Content>
