<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="AutofacDependencyInjectionWithWebForms._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gv_dados" runat="server"></asp:GridView>
            <asp:Button ID="btn_dados" runat="server" Text="Carregar" />
        </div>
    </form>
</body>
</html>
