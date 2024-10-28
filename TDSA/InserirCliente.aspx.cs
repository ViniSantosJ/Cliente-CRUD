using System;
using System.Linq;
using System.Web.UI;
using TDSA.Models;

namespace TDSA
{
    public partial class InserirCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var context = new ClienteContext())
                {
                    var novoId = context.Clientes.OrderByDescending(c => c.CliId).FirstOrDefault()?.CliId + 1 ?? 1;
                    txtId.Text = novoId.ToString();
                }
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (var context = new ClienteContext())
                {
                    var novoCliente = new Models.Cliente
                    {

                        CliNome = txtNome.Text,
                        CliDataNascimento = DateTime.Parse(txtDataNascimento.Text),
                        CliAtivo = chkAtivo.Checked
                    };
                    context.Clientes.Add(novoCliente);
                    context.SaveChanges();
                }
                ClientScript.RegisterStartupScript(this.GetType(), "closeWindow", "window.close();", true);
            }
        }

    }
}