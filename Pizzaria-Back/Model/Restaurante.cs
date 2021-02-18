using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapidotnet.Model
{
    public class Restaurante
    {
        public Restaurante() { }
        public Restaurante(int Id, string nome)
        {
            this.Id = Id;
            this.Nome = nome;
        }
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter de 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter de 3 a 60 caracteres")]
        public string Nome { get; set; }

        public int PizzaId { get; set; }
       public  IEnumerable<Pizza> Pizza { get; set; }
       
     
        }
    }
