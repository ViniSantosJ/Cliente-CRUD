<%@ Page Title="Cliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="TDSA.Cliente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="./Content/site.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
        function confirmDelete() {
            return confirm('Deseja realmente excluir? \nEssa operação não pode ser revertida!');
        }
    </script>

    <asp:ValidationSummary ID="vsErrors" runat="server" ForeColor="Red" />

    <main aria-labelledby="title" style="margin-left: 1.2em;">
        <h5 id="title">Cadastro <%: Title %></h5>
        <hr />
        <table>
            <tr>
                <th>
                    <asp:TextBox ID="txtPesquisa" class="form-control" placeholder="Nome" runat="server" MaxLength="200"></asp:TextBox>
                </th>
                <th>
                    <asp:Button ID="btnPesquisar" class="btn btn-primary" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" CausesValidation="false" />
                </th>
                <th>
                    <asp:Button ID="btnInserir" class="btn btn-primary" runat="server" Text="Inserir" OnClick="btnInserir_Click" CausesValidation="false" />
                </th>
            </tr>
        </table>
        <br />

        <asp:GridView ID="gvClientes" CssClass="gridview" runat="server" AutoGenerateColumns="false" DataKeyNames="CliId" OnRowDeleting="gvClientes_RowDeleting" OnRowEditing="gvClientes_RowEditing" OnRowUpdating="gvClientes_RowUpdating" OnRowCancelingEdit="gvClientes_RowCancelingEdit" OnPageIndexChanging="gvClientes_PageIndexChanging" AllowPaging="true" PageSize="10" PagerStyle-CssClass="pager">
            <Columns>
                <asp:BoundField DataField="CliId" HeaderText="ID" ReadOnly="true" />
                <asp:TemplateField HeaderText="NOME">
                    <ItemTemplate>
                        <asp:Label ID="lblNome" runat="server" Text='<%# Bind("CliNome") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNome" runat="server" Text='<%# Bind("CliNome") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" ErrorMessage="O preenchimento do campo NOME é obrigatório" Display="None" />
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ATIVO">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkAtivoView" runat="server" Checked='<%# Convert.ToBoolean(Eval("CliAtivo")) %>' Enabled="false"></asp:CheckBox>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:CheckBox ID="chkAtivo" runat="server" Checked='<%# Convert.ToBoolean(Eval("CliAtivo")) %>'></asp:CheckBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CliDataNascimento" HeaderText="NASCIMENTO" ReadOnly="true" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="False" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEditar" runat="server" CommandName="Edit" Text="Editar" class="btn btn-warning" CausesValidation="false" />
                        <asp:LinkButton ID="btnExcluir" runat="server" CommandName="Delete" Text="Excluir" OnClientClick="return confirmDelete();" class="btn btn-danger" CausesValidation="false" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="lnkAtualizar" runat="server" CommandName="Update" Text="Salvar" class="btn btn-success" />
                        <asp:LinkButton ID="lnkCancelar" runat="server" CommandName="Cancel" Text="Cancelar" class="btn btn-light" CausesValidation="false" />
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </main>
</asp:Content>
