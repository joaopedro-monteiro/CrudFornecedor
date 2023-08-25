using CrudFornecedor.Models.Enums;

namespace CrudFornecedor.Models;

public class Fornecedor
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Nome { get; set; }
    public long Cnpj { get; set; }
    public Especialidade Especialidade { get; set; }
    public long Cep { get; set; }
    public string? EnderecoRua { get; set; }
    public int EnderecoNumero { get; set; }
    public string? EnderecoBairro { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
}
