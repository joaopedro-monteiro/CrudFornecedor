﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CrudFornecedor.CustomValidation;
using CrudFornecedor.Helpers;
using CrudFornecedor.Models.Enums;

namespace CrudFornecedor.Models;

public class Fornecedor
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "'{0}' é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O tamanho máximo permitido é de 100 caracteres")]
    public string? Nome { get; set; }

    [StringLength(18, ErrorMessage = "O CNPJ deve conter apenas 14 números")]
    [DisplayName("CNPJ")]
    [CnpjValidation(ErrorMessage = "CNPJ inválido")]
    public string? Cnpj { get; set; }

    [DisplayName("CNPJ")]
    [NotMapped]
    public string? CnpjFormatado => CnpjHelper.Formatar(Cnpj);

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
    public Estado Estado { get; set; }
}