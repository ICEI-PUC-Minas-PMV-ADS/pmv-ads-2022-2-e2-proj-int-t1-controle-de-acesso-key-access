using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyAcess01.Models
{
    [Table("Visitantes")]
    public class Visitante
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

        public string Telefone { get; set; }

        [Display(Name = "Horario Entrada")]
        [Required(ErrorMessage = "Obrigatório informar o horario de entrada da visita!")]
        public DateTime HrrEnt { get; set; }

        [Display(Name = "Horario Saída")]
        public DateTime HrrSaid { get; set; }
    }
}
