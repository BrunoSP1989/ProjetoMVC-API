using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo deverá ser preenchido!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo deverá ser preenchido!")]
        [Range(1,10,ErrorMessage ="Valor fora da faixa!!!")]
        public int Quantidade { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
