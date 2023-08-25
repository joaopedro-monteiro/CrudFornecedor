namespace CrudFornecedor.Models;

public class Endereco
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Rua { get; set; }
    public string? Complemento { get; set; }
    public string? Bairo { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public int Numero { get; set; }
}
