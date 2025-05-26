<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="LOrd_Card_Shop.View.TransactionHistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <div >
            <h1>Transaction History</h1>
            <asp:GridView ID="TransactionHistoryGridForAdmin" runat="server" AutoGenerateColumns="False" OnRowEditing="TransactionHistoryGridForAdmin_RowEditing">  
                <Columns>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:Button ID="Edit" runat="server" Text="Detail"  CommandName="Edit"/>
                        </ItemTemplate>
                    </asp:TemplateField>

                   

                    <asp:BoundField DataField="TransactionId" HeaderText="TransactionId" SortExpression="TransactionId" />
                    <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
                    <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
      

                </Columns>

            </asp:GridView><br/>

        </div>
        <div >
            <asp:GridView ID="TransactionHistoryGridForUser" runat="server" AutoGenerateColumns="False" OnRowEditing="TransactionHistoryGridForUser_RowEditing">  
                <Columns>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" Text="Detail"  CommandName="Edit"/>
                        </ItemTemplate>
                    </asp:TemplateField>

                   

                    <asp:BoundField DataField="TransactionId" HeaderText="TransactionId" SortExpression="TransactionId" />
                    <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
      

                </Columns>

            </asp:GridView><br/>

        </div>
</asp:Content>
