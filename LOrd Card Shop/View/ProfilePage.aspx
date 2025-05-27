<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="LOrd_Card_Shop.View.ProfilePageaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Profile Page</h1>
        <div>
            <asp:Label runat="server" Text="Username: "></asp:Label>
            <br />
            <asp:TextBox ID="UsernameTb" runat="server" />

            <br />

            <asp:Label runat="server" Text="Email:" />
            <br />
            <asp:TextBox ID="EmailTb" runat="server" />

            <br />

            <asp:Label runat="server" Text="Gender:" />
            <br />
            <asp:DropDownList ID="GenderDdl" runat="server">
                <asp:ListItem ID="GenderDdlText" Text=" " Value="" />
                <asp:ListItem Text="Male" Value="Male" />
                <asp:ListItem Text="Female" Value="Female" />
            </asp:DropDownList>

            <br />

            <asp:Label runat="server" Text="Old Password:" />
            <br />
            <asp:TextBox ID="OldPasswordTb" runat="server" />

            <br />

            <asp:Label runat="server" Text="New Password:" />
            <br />
            <asp:TextBox ID="NewPasswordTb" runat="server" TextMode="Password" />

            <br />

            <asp:Label runat="server" Text="Confirm New Password:" />
            <br />
            <asp:TextBox ID="ConfirmPasswordTb" runat="server" TextMode="Password" />

            <br /> <br />
            <asp:Label ID="ErrorLbl" runat="server" Text=" "></asp:Label> <br />
            <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
        </div>
</asp:Content>
