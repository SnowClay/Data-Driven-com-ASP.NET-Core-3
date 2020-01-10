using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; private set; }
        [Required(ErrorMessage = "Esse campo deve ser preenchido")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Title { get; private set; }        
        [MaxLength(1024, ErrorMessage = "Este campo deve conter 1024 caracteres")]    
        public string Description { get; private set; }
        [Required(ErrorMessage = "Esse campo deve ser preenchido")]
        [Range(1, int.MaxValue, ErrorMessage = "O preco deve ser maior que zero")]

        public decimal Price { get; private set; }
        [Required(ErrorMessage = "Esse campo deve ser preenchido")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria invalida")]

        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
    
    }
}