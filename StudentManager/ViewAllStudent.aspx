<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewAllStudent.aspx.cs" Inherits="StudentManager.ViewAllStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>View All Student</h1>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Student Name" />
                <asp:BoundField DataField="RegisterNumber" HeaderText="Roll No" />
                <asp:BoundField DataField="StudentCategory" HeaderText="Categories" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="EditStudent.aspx?id=(0)" HeaderText="Edit" Text="Edit" />
            </Columns>
        </asp:GridView>
    </p>
    <p>&nbsp;</p>
</asp:Content>
