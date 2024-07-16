<%@ Page Title="Subject Info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SubjectInfo.aspx.cs" Inherits="ProjectAAS.SubjectInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     ID
 <br />
 <asp:DropDownList ID="NumericUpDown1" runat="server" Enabled="false" style="margin-bottom: 10px;" />
 <br />
 Name
 <br />
 <asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 10px;"/>
 <br />
 <br />
 <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click"
/>
</asp:Content>
