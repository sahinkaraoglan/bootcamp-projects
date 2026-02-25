<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="session._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script runat="server">
        private void yazdir(object sender, EventArgs e)
        {
            //Label1.Text = TextBox1.Text;
            //Label2.Text = TextBox2.Text;
            //Label3.Text = TextBox3.Text;

            if(Page.IsPostBack)
            {
                Label1.Text = "sayfa daha önce yüklenmiştir";
            }
        }
        private void sil(object sender, EventArgs e)
        {
            Label1.Text = " ";
        }
        private void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                Label1.Text = "sayfa bir kere yüklendi";
            }
        }
        private void gonder(object sender, EventArgs e)
        {
            Response.Redirect("al.aspx?isim=ahmet&meslek=bilgisayar");
            Response.Redirect("al.aspx?isim=" + TextBox1.Text +"&meslek=" + TextBox2.Text);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" ForeColor="#FF0066"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="yazdir" AutoPostBack="True"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="yazdir"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="yazdir" AutoPostBack="true"></asp:TextBox>
            <br />
            <asp:Button ID="button1" runat="server" Text="yazdır" OnClick="yazdir"/>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="gonder"/>
            <br />
            <input type="button" value="mesaj sil" runat="server" />
        </div>
    </form>
</body>
</html>
