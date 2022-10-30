using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyAcess01.Models
{
    [Table("Apartamentos")]
    public class Apartamento
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nmr Apartamento")]
        [Required(ErrorMessage = "Obrigatório informar o número do apartamento!")]
        public string NmrApartamento { get; set; }

        [Display(Name = "Qtd Moradores")]
        [Required(ErrorMessage = "Obrigatório a quantidade de moradores!")]
        public string QtdMoradores { get; set; }


        public ICollection<Residente> Residentes { get; set; } // chamamos isso de relacionamento virtual, na tabela do banco de dados não cria nada relacionado a essa config.
        public ICollection<Visitante> Visitantes { get; set; }

    }
}
