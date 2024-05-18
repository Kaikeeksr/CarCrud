using System.ComponentModel.DataAnnotations;

namespace CarCrud.Models
{
    public class CarModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Digite o modelo do carro")]
        [StringLength(100, ErrorMessage = "O modelo pode ter no máximo 100 caracteres")]
        public string modelo { get; set; }

        [Required(ErrorMessage = "Digite a placa do carro")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "A placa do carro deve conter exatamente 7 caracteres")]
        public string placa { get; set; }

        [Required(ErrorMessage = "Digite o código renavam do carro")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O Código renavam deve conter exatamente 9 dígitos")]
        [RegularExpression(@"\d{9}", ErrorMessage = "O Código renavam deve conter apenas dígitos")]
        public string renavam { get; set; }

        [Required(ErrorMessage = "Digite o ano de fabricação do carro")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Ano do carro deve conter exatamente 4 dígitos, exemplo: 2024")]
        [RegularExpression(@"\d{4}", ErrorMessage = "O ano de fabricação deve conter apenas dígitos")]
        public string ano_fabricacao { get; set; }

        [Required(ErrorMessage = "Digite a cor predominante")]
        public string cor { get; set; }

        [Required(ErrorMessage = "Digite a potência (em cv) do carro")]
        public string potencia { get; set; }

        [Required(ErrorMessage = "Selecione a categoria do carro")]
        public string categoria { get; set; }
    }
}
