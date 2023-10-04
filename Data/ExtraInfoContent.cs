namespace Curriculo.Data;

public class Contacts
{
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string Github { get; set; }
    public required string LinkedIn { get; set; }
}

public class Skill
{
    public required string Title { get; set; }
    public required int LevelPercent { get; set; }
}

public class Language
{
    public required string  Title { get; set; }
    public required string?  FullDescription { get; set; }
    public required List<string>  Description { get; set; }
}

public class ExtraInfoContent
{
    public required string  AvatarUrl { get; set; }
    public required Contacts Contacts { get; set; }
    public required string Localization { get; set; }
    public required List<Skill> Skills { get; set; }

    public required List<Language> Languages { get; set; }
}