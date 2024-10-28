<%@ Page Title="Inserir Cliente" Language="C#" MasterPageFile="~/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="InserirCliente.aspx.cs" Inherits="TDSA.InserirCliente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="./Content/InserirCliente.css" rel="stylesheet" type="text/css" />


    <main aria-labelledby="title">
        <h2 id="title" style="text-align: center;"><%: Title %></h2>

        <div class="form-container">
            <asp:ValidationSummary ID="vsErrors" runat="server" ForeColor="Red" />

            <asp:Label ID="lblId" runat="server" Text="ID: " />
            <asp:TextBox ID="txtId" runat="server" ReadOnly="true" />
            <br />
            <asp:Label ID="lblNome" runat="server" Text="Nome: " />
            <asp:TextBox ID="txtNome" runat="server" />
            <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Nome é obrigatório" Display="None" />
            <br />
            <asp:Label ID="lblDataNascimento" runat="server" Text="Data de Nascimento: " />
            <asp:TextBox ID="txtDataNascimento" runat="server" type="Date" />
            <asp:RequiredFieldValidator ID="rfvDataNascimento" runat="server" ControlToValidate="txtDataNascimento" ErrorMessage="Data de Nascimento é obrigatória" Display="None" />
            <br />
            <asp:Label ID="lblAtivo" runat="server" Text="Ativo: " />
            <asp:CheckBox ID="chkAtivo" runat="server" MaxLength="1" />
            <br />
            <br />
            <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" CausesValidation="true" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClientClick="window.close();" />
        </div>
    </main>
</asp:Content>
