using System.ComponentModel;

namespace CrudFornecedor.Models.Enums;

public enum Especialidade
{
    [Description("Comércio")]
    Comercio,

    [Description("Serviço")]
    Servico,

    [Description("Indústria")]
    Industria
}