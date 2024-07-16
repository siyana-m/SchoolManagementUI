<%@ Page Title="Grade Info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GradeInfo.aspx.cs" Inherits="ProjectAAS.GradeInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 FNumber
 <br />
 <asp:DropDownList ID="ComboBox1" runat="server" Enabled="false" style="margin-bottom: 10px;"/>
 <br />
 SubjectID
 <br />
 <asp:DropDownList ID="ComboBox2" runat="server" style="margin-bottom: 10px;"/>
 <br />
 <br />
  FinalGrade
 <br />
 <asp:TextBox ID="NumericUpDown1" runat="server" Enabled="false" />
 <br />
 <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click"
/>
</asp:Content>
