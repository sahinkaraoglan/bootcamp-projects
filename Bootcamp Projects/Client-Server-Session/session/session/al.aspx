<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="al.aspx.cs" Inherits="session.al" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script runat="server">
        private void Page_Load(object sender, EventArgs e)
        {
            Response.Write("hoşgeldiniz" +   Request.QueryString["isim"] +   Request.QueryString["meslek"]);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
