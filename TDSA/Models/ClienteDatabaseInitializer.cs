using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace TDSA.Models
{
    public class ClienteDatabaseInitializer : DropCreateDatabaseIfModelChanges<ClienteContext>
    {
        protected override void Seed(ClienteContext context)
        {
            GetClientes().ForEach(c => context.Clientes.Add(c));
        }

        private static List<Cliente> GetClientes()
        {
            var clientes = new List<Cliente>
            {
                new Cliente
                {
                CliId = 1,
                CliNome = "Carlos Almeida",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                new Cliente
                {
                CliId = 2,
                CliNome = "Fernando Oliveira",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                new Cliente
                {
                CliId = 3,
                CliNome = "Jorge Ferreira",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                new Cliente
                {
                CliId = 4,
                CliNome = "Lucas Hernadez",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                                new Cliente
                {
                CliId = 5,
                CliNome = "Vinicius Albuquerque",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                new Cliente
                {
                CliId = 6,
                CliNome = "Camila Gonçalves",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                                new Cliente
                {
                CliId = 7,
                CliNome = "João Pedro da Silva",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                new Cliente
                {
                CliId = 8,
                CliNome = "Fernando Batista",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                                new Cliente
                {
                CliId = 9,
                CliNome = "Carlos O. Pessoa",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                new Cliente
                {
                CliId = 10,
                CliNome = "Milena Fernandez",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                                new Cliente
                {
                CliId = 11,
                CliNome = "Alexandre Botelho",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
                new Cliente
                {
                CliId = 12,
                CliNome = "Jean Carvalho",
                CliDataNascimento = DateTime.Now,
                CliAtivo = true
                },
            };
            return clientes;
        }
    }
}