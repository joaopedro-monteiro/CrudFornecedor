using CrudFornecedor.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace CrudFornecedor.Models;

public class Fornecedor
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O tamanho máximo permitido é de 100 caracteres")]
    public string? Nome { get; set; }

   [StringLength(18, ErrorMessage = "O CNPJ deve conter apenas 14 números")]
    public string? Cnpj { get; set; }
    public Especialidade Especialidade { get; set; }

    [DataType(DataType.PostalCode)]
    public string? Cep { get; set; }
    public string? EnderecoRua { get; set; }

    
    public string? EnderecoNumero { get; set; }
    public string? EnderecoBairro { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
}
