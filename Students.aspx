<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="ProjectAAS.Students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:GridView ID="GridViewContent" runat="server"
OnRowCommand="GridViewContent_RowCommand" AutoGenerateColumns="False">
 <Columns>
 <asp:ButtonField ButtonType="Link"
 CommandName="Select"
 HeaderText=""
 Text="Select" />
    <asp:BoundField HeaderText="FNumber" DataField="FNumber"></asp:BoundField>
    <asp:BoundField HeaderText="SpecialtyId" DataField="SpecialtyId"></asp:BoundField>
     <asp:BoundField HeaderText="FName" DataField="FName"></asp:BoundField>
     <asp:BoundField HeaderText="MName" DataField="MName"></asp:BoundField>
     <asp:BoundField HeaderText="LName" DataField="LName"></asp:BoundField>
     <asp:BoundField HeaderText="Address" DataField="Address"></asp:BoundField>
     <asp:BoundField HeaderText="Phone" DataField="Phone"></asp:BoundField>
     <asp:BoundField HeaderText="EMail" DataField="EMail"></asp:BoundField>
 </Columns>
 </asp:GridView>
</asp:Content>
