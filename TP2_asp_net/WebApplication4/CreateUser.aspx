<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="WebApplication4.CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> creation des user</title>
</head>
<body><form id="form1"  runat="server"  method="post">
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
            <asp:Button Text="Create the user" runat="server" OnClick="create_click"/>
        </form>
</body>
</html>
