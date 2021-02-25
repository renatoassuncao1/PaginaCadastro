<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCadastro.aspx.cs" Inherits="PaginaCadastro.FormCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="styles/site.css" />
    <title>Retorno Cadastro</title>
    <script src="script.js"></script>
</head>
<body>
    
    
    <form id="form1" runat="server" >
        
        <div runat="server" id="Cadastro">
            <img src="images/logo.png" alt ="Logo" style="width:100px" id="logo1" />
            <h3>Dados enviados pelo formulário</h3>
            
            <asp:Label  runat="server" AssociatedControlID="txtNome">Nome:</asp:Label>
            <asp:TextBox runat="server" ID="txtNome"></asp:TextBox><br />

            <asp:Label  runat="server" AssociatedControlID="txtTelefone">Telefone:</asp:Label>
            <asp:TextBox runat="server" ID="txtTelefone"></asp:TextBox><br />

            <asp:Label  runat="server" AssociatedControlID="txtEmail">E-mail:</asp:Label>
            <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox><br /> <br /><br />

            <asp:Button runat ="server" ID="BTNcadastrar"  Text="Cadastrar" OnClick ="BTNcadastrar_Click" />
            <br /><br /><br />

            <asp:Button runat ="server" ID="BTNconsultar"  Text="Consultar" OnClick ="BTNconsultar_Click" />
            <br /><br /><br />

            <div runat="server" id="DIVdadostabela"></div>

            <a href="javascript:alert"('Hello world');">Veja uma execução de JavaScript</a>
             <br/>
                <br/>
                <p runat="server" id="Frase">Esta é uma Frase.</p>
                 <br/>
                 <button runat="server" type="button" onclick="alteraParagrafo()">Mudar Frase</button>
           
        </div>
    </form>
</body>
</html>
