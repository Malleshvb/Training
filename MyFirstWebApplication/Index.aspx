<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MyFirstWebApplication.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Hello world</h1>
        <p>&nbsp;</p>
        <p>
            <asp:Image ID="Image1" runat="server" Height="142px" ImageUrl="~/Images/download.jpg" Width="254px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter Your Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtUserName" runat="server" Width="249px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Your Fav Movie"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ddlFavMovieList" runat="server" Height="31px" Width="224px">
            <asp:ListItem>Select Fav Movie</asp:ListItem>
            <asp:ListItem>Iron Man</asp:ListItem>
            <asp:ListItem>Super</asp:ListItem>
            <asp:ListItem>Iron Man 2</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="chkWatchMovieInHome" runat="server" Text="I watched the movie in home" />
        <br />
        <br />
        <asp:CheckBox ID="chkWatchMovieInTheater" runat="server" Text="I watched the movie in theater" />
        <br />
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="WatchAgain" Text="Love to watch again" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="WatchAgain" Text="Dont want watch again" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="150px" Width="219px">
            <asp:ListItem>Take My Breath Away</asp:ListItem>
            <asp:ListItem>Fade To Black</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <br />
        <p>
            <asp:Button ID="btnShowSalutation_Click" runat="server" OnClick="btnShowSalutation_Click_Click" Text="Click Me" />
        </p>
        <asp:Label ID="lblMessage" runat="server" Text="lblMessage"></asp:Label>
    </form>
</body>
</html>
