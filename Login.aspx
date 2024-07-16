<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectAAS.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Потребителско име
 <br />
 <asp:TextBox ID="username" runat="server" />
 <br />
 Парола
 <br />
 <asp:TextBox ID="password" runat="server" TextMode="Password" />
 <br />
 <br />
 <asp:Button ID="submit" runat="server" Text="Вход" OnClick="submit_Click" />
</asp:Content>
