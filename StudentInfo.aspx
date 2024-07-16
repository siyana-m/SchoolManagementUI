<%@ Page Title="Student Info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentInfo.aspx.cs" Inherits="ProjectAAS.StudentInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 FNumber
 <br />
 <asp:DropDownList ID="NumericUpDown1" runat="server" Enabled="false" style="margin-bottom: 10px;"/>
 <br />
 SpecialtyID
 <br />
 <asp:DropDownList ID="ComboBox1" runat="server" Enabled="false" style="margin-bottom: 10px;" />
 <br />
 FName
 <br />
 <asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 10px;" />
 <br />
 <br />
 MName
 <br />
 <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 10px;" />
 <br />
 <br />
 LName
 <br />
 <asp:TextBox ID="TextBox3" runat="server" style="margin-bottom: 10px;" />
 <br />
 <br />
 Address
 <br />
 <asp:TextBox ID="TextBox4" runat="server" style="margin-bottom: 10px;" />
 <br />
 <br />
 Phone
 <br />
 <asp:TextBox ID="TextBox5" runat="server" style="margin-bottom: 10px;" />
 <br />
 <br />
 EMail
 <br />
 <asp:TextBox ID="TextBox6" runat="server" style="margin-bottom: 10px;" />
 <br />
 <br />
 <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click"
/>
</asp:Content>
