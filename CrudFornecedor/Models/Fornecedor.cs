using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CrudFornecedor.CustomValidation;
using CrudFornecedor.Helpers;
using CrudFornecedor.Models.Enums;

namespace CrudFornecedor.Models;

public class Fornecedor
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "'{0}' é obrigatório e deve conter no máximo 100 caracteres.")]
    [StringLength(100, MinimumLength = 0, ErrorMessage = "O tamanho máximo permitido é de 100 caracteres")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "'{0}' é obrigatório e deve conter apenas 14 números.")]
    [StringLength(18, MinimumLength = 14, ErrorMessage = "O CNPJ deve conter 14 números")]
    [DisplayName("CNPJ")]
    [CnpjValidation(ErrorMessage = "CNPJ inválido")]
    public string? Cnpj { get; set; }

    [DisplayName("CNPJ")]
    [NotMapped]
    public string? CnpjFormatado => CnpjHelper.Formatar(Cnpj);

    [DisplayName("CEP")]
    [NotMapped]
    public string? CepFormatado => CepHelper.Formatar(Cep);

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    public Especialidade Especialidade { get; set; }

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    [StringLength(9, MinimumLength = 8, ErrorMessage = "O CEP deve conter 8 dígitos")]
    [DisplayName("CEP")]
    public string? Cep { get; set; }

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    [DisplayName("Rua")]
    public string? EnderecoRua { get; set; }

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    [DisplayName("Nº")]
    public string? EnderecoNumero { get; set; }

    [DisplayName("Complemento")]
    public string? EnderecoComplemento { get; set; }

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    [DisplayName("Bairro")]
    public string? EnderecoBairro { get; set; }

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    public string? Cidade { get; set; }

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    public Estado Estado { get; set; }
}