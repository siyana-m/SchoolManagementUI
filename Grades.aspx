<%@ Page Title="Grades" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grades.aspx.cs" Inherits="ProjectAAS.Grades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:GridView ID="GridViewContent" runat="server"
OnRowCommand="GridViewContent_RowCommand" AutoGenerateColumns="False" RowStyle-CssClass="grid-row" CellStyle-CssClass="grid-cell">
 <Columns>
 <asp:ButtonField ButtonType="Link"
 CommandName="Select"
 HeaderText=""
 Text="Select" />
 <asp:BoundField HeaderText="FNumber" DataField="FNumber"></asp:BoundField>
 <asp:BoundField HeaderText="SubjectId" DataField="SubjectId"></asp:BoundField>
 <asp:BoundField HeaderText="FinalGrade" DataField="FinalGrade"></asp:BoundField>
 </Columns>
 </asp:GridView>
</asp:Content>
