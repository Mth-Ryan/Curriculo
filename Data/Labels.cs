namespace Curriculo.Data;
public class MainLabels
{
    public string Experience { get; set; }
    public string Education { get; set; }

    public MainLabels(string experience, string education)
    {
        Experience = experience;
        Education = education;
    }
}

public class ExtraLabels
{
    public string Contacts { get; set; }
    public string Localization { get; set; }
    public string Skills { get; set; }
    public string Languages { get; set; }

    public ExtraLabels(string contacts,
        string localization,
        string skills,
        string languages)
    {
        Contacts = contacts;
        Localization = localization;
        Skills = skills;
        Languages = languages;
    }
}

public class Labels
{
    public LanguageVariant Variant { get; set; }
    public MainLabels MainLabels { get; set; }
    public ExtraLabels ExtraLabels { get; set; }

    public Labels(
        LanguageVariant variant,
        MainLabels main,
        ExtraLabels extra)
    {
        Variant = variant;
        MainLabels = main;
        ExtraLabels = extra;
    }
}