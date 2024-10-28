<%@ Page Title="Sobre" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="TDSA.Sobre" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container text-left">
        <h2>Sobre</h2>
        <br />
        <div class="container">
            <p>Ao iniciar o projeto, será criado um banco de dados local e inserido alguns cadastros para exibir a paginação. </p>
            <asp:Button ID="btnPesquisar" class="btn btn-primary" runat="server" Text="Pesquisar" /> irá pesquisar os clientes cujo o nome tem parte do texto digitado. <br /><br />
            <asp:Button ID="btnInserir" class="btn btn-primary" runat="server" Text="Inserir" /> abre uma nova janela, onde é possível inserir um novo cliente. <br /><br />
            <asp:LinkButton runat="server" Text="Editar" class="btn btn-warning" /> permite que seja editado os dados do cliente. <br /><br />
            <asp:LinkButton  runat="server" Text="Excluir" class="btn btn-danger" /> permite que seja excluído o cadastro do cliente.
    </div>
</asp:Content>
