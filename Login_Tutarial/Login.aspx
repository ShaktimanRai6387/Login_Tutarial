<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login_Tutarial.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-Style1">
                <caption>Login Form</caption>
                <tr>
                    <td>User:</td>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        <br />
                         <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                    </td>
                  
                    <td align="right">
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" ForeColor="Red" />
                    </td>
                </tr>
              
            </table>
           

        </div>
    </form>
</body>
</html>
