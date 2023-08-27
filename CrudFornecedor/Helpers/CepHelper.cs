namespace CrudFornecedor.Helpers;

public class CepHelper
{
    public static string? Formatar(string? cep)
    {
        if (string.IsNullOrEmpty(cep))
            return cep;

        return $"{cep.Substring(0, 5)}-{cep.Substring(5)}";
    }
}
