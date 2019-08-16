<%@ Page Language="C#" %>
<link href="http://localhost:57907/Stylesheet.css" rel="stylesheet" />
<!DOCTYPE html>
<script runat="server">

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }
</script>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title>CM Data and Retention</title>
</head>
<body>
    <div id="head1">
        <h1>Data and Retention Application</h1>
    </div>
    <h2> Login</h2>
    <form id="form1" runat="server"> 
        
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
        </asp:Login>
        
    </form>
</body>
</html>
