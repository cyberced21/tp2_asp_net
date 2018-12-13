<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

    <body>
        <form id="form1"  runat="server"  method="post">
        Username:
            <asp:TextBox ID="username" runat="server" />
            <asp:RequiredFieldValidator ID="usernameReq"
                runat="server"
                ControlToValidate="username"
                ErrorMessage="Username is required!"
                SetFocusOnError="True" />
            <br />
        Password:
            <asp:TextBox ID="password" runat="server"  />  
            <asp:RequiredFieldValidator ID="passwordReq"
                runat="server"
                ControlToValidate="password"
                ErrorMessage="Password is required!"
                SetFocusOnError="True" />
                <br />
            <asp:Button Text="submit" runat="server" PostBackUrl="~/About" />


        </form>
    </body>
</html>
