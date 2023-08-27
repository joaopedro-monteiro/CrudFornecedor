using System.ComponentModel;

namespace CrudFornecedor.Extensions;

public static class EnumExtensions
{
    public static string GetDescription<TEnum>(this TEnum value) where TEnum : Enum
    {
        var type = value.GetType();
        var field = type.GetField(value.ToString());

        if (field == null)
            return value.ToString();

        var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
        var attribute = attributes.FirstOrDefault() as DescriptionAttribute;

        return attribute?.Description ?? value.ToString();
    }
}