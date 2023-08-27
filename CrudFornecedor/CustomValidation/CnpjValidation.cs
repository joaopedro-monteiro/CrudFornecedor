using System.ComponentModel.DataAnnotations;
using CrudFornecedor.Helpers;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CrudFornecedor.CustomValidation;

public sealed class CnpjValidation : ValidationAttribute, IClientModelValidator
{
    private readonly string[] _errors =
    {
        "CNPJ Inválido",
        "Formato inválido"
    };

    public void AddValidation(ClientModelValidationContext context)
    {
        if (context == null)
            throw new ArgumentNullException(nameof(context));

        context.Attributes.Add("data-val", "true");
        context.Attributes.Add("data-val-cnpj-validation", GetValidationClientErrorMessage());
    }

    public override bool IsValid(object? value)
    {
        if (value == null || string.IsNullOrEmpty(value.ToString()))
            return false;

        return CnpjHelper.Valido(value.ToString());
    }

    private string GetValidationClientErrorMessage()
    {
        var str = !string.IsNullOrEmpty(ErrorMessage) ? ErrorMessage : _errors[0];

        return string.Format(str);
    }
}