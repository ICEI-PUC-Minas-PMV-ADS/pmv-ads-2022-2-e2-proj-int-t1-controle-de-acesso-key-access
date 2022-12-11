using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyAcess01.Models
{
    [Table("BloquearVisitantes")]
    public class BloquearVisitante
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Apartamento")]
        [Required(ErrorMessage = "Obrigatório informar o apartamento visitado!")]
        public int ApartamentoId { get; set; }

        [ForeignKey("ApartamentoId")]
        public Apartamento Apartamento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Obrigatório infomar o CPF")]
        public string Cpf { get; set; }
    }
}
