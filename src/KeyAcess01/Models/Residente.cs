using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyAcess01.Models
{
    [Table("Residentes")]
    public class Residente
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Apartamento")]
        [Required(ErrorMessage = "Obrigatório infomar o apartamento!")]
        public int ApartamentoId { get; set; }

        [ForeignKey("ApartamentoId")]
        public Apartamento Apartamento { get; set; }



        /*[Display(Name = "Apartamento")]
        [Required(ErrorMessage = "Obrigatório infomar o apartamento!")]
        public ApartamentosCriados ApartamentoCriado { get; set; } // Tipo ApartamentosCriados */

        [Required(ErrorMessage = "Obrigatório infomar o nome!")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Obrigatório infomar o CPF!")]
        public string Cpf { get; set; }

        public string Telefone { get; set; }

        
        



    }

   /* public enum ApartamentosCriados
    {
        A01,
        A02,
        A03,
        A04,
        A05,
        B01,
        B02,
        B03
    }*/
}
