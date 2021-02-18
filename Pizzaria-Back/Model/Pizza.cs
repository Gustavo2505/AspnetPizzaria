using System.ComponentModel.DataAnnotations;

namespace webapidotnet.Model
{
    public class Pizza
    {


        public Pizza() { }
        public Pizza(int Id, string nome, int preco)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.preco = preco;

        }
        [Key]
      
        public int Id{ get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage ="Este campo deve conter de 3 a 60 caracteres")]
        [MinLength(3,ErrorMessage = "Este campo deve conter de 3 a 60 caracteres")]
        public string Nome{ get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalido")]
        public int preco { get; set; }

    }
}