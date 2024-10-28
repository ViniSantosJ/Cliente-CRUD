using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TDSA.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int CliId { get; set; }

        [Required, StringLength(200), Column(TypeName ="varchar"),Display(Name = "Nome")]
        public string CliNome { get; set; }

        [Required, Column(TypeName ="date") ,Display(Name = "Data Nascimneto")]
        public DateTime CliDataNascimento { get; set; }

     //   [Required, StringLength(1), Display(Name = "Ativo")]
        [Required, Display(Name = "Ativo")]
        public bool CliAtivo { get; set; }

    }

}