namespace Curriculo.Data;

public class LabelsService
{
    public readonly Labels PtLabels = new(
        LanguageVariant.Pt,
        new MainLabels("Experiência", "Educação"),
        new ExtraLabels("Contatos", "Localização", "Skills", "Idiomas"));

    public readonly Labels EnLabels = new(
        LanguageVariant.En,
        new MainLabels("Experience", "Education"),
        new ExtraLabels("Contacts", "Localization", "Skills", "Languages"));

    public Labels GetLabels(LanguageVariant variant)
    {
        return variant switch
        {
            LanguageVariant.Pt => PtLabels,
            LanguageVariant.En => EnLabels,
            _ => throw new IndexOutOfRangeException("No label with the given input")
        };
    }
}