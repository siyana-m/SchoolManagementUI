<%@ Page Title="Subjects" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subjects.aspx.cs" Inherits="ProjectAAS.Subjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:GridView ID="GridViewContent" runat="server"
OnRowCommand="GridViewContent_RowCommand" AutoGenerateColumns="False">
 <Columns>
 <asp:ButtonField ButtonType="Link"
 CommandName="Select"
 HeaderText=""
 Text="Select" />
 <asp:BoundField HeaderText="ID" DataField="ID"></asp:BoundField>
 <asp:BoundField HeaderText="Name" DataField="Name"></asp:BoundField>
 </Columns>
 </asp:GridView>
</asp:Content>
