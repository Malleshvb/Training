<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="StudentManager.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add Student</h1>
    


    <asp:Label ID="Label3" runat="server" Text="[lblMessageBox]"></asp:Label>
<br />
<br />
<br />
<asp:Label ID="Label1" runat="server" Text="Student name"></asp:Label>
<br />
    


    <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
    <br />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtStudentName" ErrorMessage="Student Name is Mandatory"></asp:RequiredFieldValidator>
<br />
<br />
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStudentName" ErrorMessage="The student Name must be alphabets" ValidationExpression="[a-zA-Z]*"></asp:RegularExpressionValidator>
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="Category"></asp:Label>
<br />
<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CategoryName" DataValueField="CategoryName">
</asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrainingConnectionString %>" SelectCommand="SELECT [CategoryId], [CategoryName] FROM [StudentCategories]"></asp:SqlDataSource>
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="Register Number"></asp:Label>
<br />
<asp:TextBox ID="txtStudentRegister" runat="server"></asp:TextBox>
<br />
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtStudentRegister" ErrorMessage="Register Number is mandatory"></asp:RequiredFieldValidator>
<br />
<br />
<br />
<asp:Button ID="btnAddStudent_Click" runat="server" OnClick="btnAddStudent_Click_Click" Text="Add Student" />
<br />
<br />
    <br />

</asp:Content>
