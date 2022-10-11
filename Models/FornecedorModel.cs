using AppCompletaMvc.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppCompletaMvc.Models
{
    public class FornecedorModel : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }
        public TipoDeFornecedor TipoDeFornecedor { get; set; }
        public EnderecoModel Endereco { get; set; }

        [DisplayName("Ativo ?")]
        public bool Ativo { get; set; }
        public IEnumerable<ProdutoModel> Produtos { get; set; }
    }
}
