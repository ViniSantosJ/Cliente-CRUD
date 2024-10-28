using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using TDSA.Models;

namespace TDSA
{
    public partial class Cliente : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // PesquisarCliente(string.Empty);
                gvClientes.Visible = false;
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            gvClientes.EditIndex = -1; // Aqui ele irá resetar o índice de edição. Dessa forma, ao clicar em Pesquisar, ele "limpa" a tela caso tenha uma edição pendente.
            gvClientes.PageIndex = 0;
            string pesquisa = txtPesquisa.Text.Trim();
            PesquisarCliente(pesquisa);
            gvClientes.Visible = true;
        }

        private void PesquisarCliente(string filtro)
        {
            using (var context = new ClienteContext())
            {

                var clientes = from cliente in context.Clientes
                               where cliente.CliNome.Contains(filtro)
                               select new
                               {
                                   cliente.CliId,
                                   cliente.CliNome,
                                   cliente.CliDataNascimento,
                                   cliente.CliAtivo
                               };

                //gvClientes.DataSource = context.Clientes.ToList();
                gvClientes.DataSource = clientes.ToList();
                gvClientes.DataBind();
            }
        }

        protected void gvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int clienteId = Convert.ToInt32(gvClientes.DataKeys[e.RowIndex].Value);

            using (var context = new ClienteContext())
            {
                var cliente = context.Clientes.FirstOrDefault(c => c.CliId == clienteId);
                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                }
            }
            PesquisarCliente(txtPesquisa.Text.Trim());

        }

        protected void gvClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvClientes.EditIndex = e.NewEditIndex;
            PesquisarCliente(txtPesquisa.Text.Trim());
        }

        protected void gvClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int clienteId = Convert.ToInt32(gvClientes.DataKeys[e.RowIndex].Value);
            GridViewRow row = gvClientes.Rows[e.RowIndex];

            string nome = ((TextBox)row.FindControl("txtNome")).Text;
            bool ativo = ((CheckBox)row.FindControl("chkAtivo")).Checked;

            using (var context = new ClienteContext())
            {
                var cliente = context.Clientes.FirstOrDefault(c => c.CliId == clienteId);
                if (cliente != null)
                {
                    cliente.CliNome = nome;
                    cliente.CliAtivo = ativo;
                    context.SaveChanges();
                }
            }
            gvClientes.EditIndex = -1;
            PesquisarCliente(txtPesquisa.Text.Trim());
        }

        protected void gvClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvClientes.EditIndex = -1;
            PesquisarCliente(txtPesquisa.Text.Trim());
        }

        protected void gvClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvClientes.PageIndex = e.NewPageIndex;
            PesquisarCliente(txtPesquisa.Text.Trim());
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            string url = "InserirCliente.aspx";
            string script = $"window.open('{url}', '_blank', 'width=400,height=550');";
            ClientScript.RegisterStartupScript(this.GetType(), "OpenWindow", script, true);
        }

    }
}