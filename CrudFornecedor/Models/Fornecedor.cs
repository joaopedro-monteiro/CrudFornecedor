using CrudFornecedor.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrudFornecedor.Models;

public class Fornecedor
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O tamanho máximo permitido é de 100 caracteres")]
    public string? Nome { get; set; }

   [StringLength(18, ErrorMessage = "O CNPJ deve conter apenas 14 números")]
    [DisplayName("CNPJ")]
    public string? Cnpj { get; set; }
    public Especialidade Especialidade { get; set; }

    [DataType(DataType.PostalCode)]
    [DisplayName("CEP")]
    public string? Cep { get; set; }

    [DisplayName("Rua")]
    public string? EnderecoRua { get; set; }

    [DisplayName("Nº")]
    public string? EnderecoNumero { get; set; }

    [DisplayName("Bairro")]
    public string? EnderecoBairro { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
}
