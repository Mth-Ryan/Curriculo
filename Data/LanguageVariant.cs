using System.Text.Json.Serialization;

namespace Curriculo.Data;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LanguageVariant
{
    Pt,
    En,
}