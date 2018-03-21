<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="StudentManager.EditStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Edit Student</h1>

<asp:Label ID="lblStudentName" runat="server" Text="Student Name"></asp:Label>
<br />
<asp:TextBox ID="txtStudentName" runat="server" ></asp:TextBox>
<br />
<br />
<asp:Label ID="Label1" runat="server" Text="Register Number"></asp:Label>
<br />
<asp:TextBox ID="txtRegisterNumber" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click_Click" style="width: 56px" Text="Button" />
<br />

</asp:Content>
