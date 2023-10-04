namespace Curriculo.Data;

public class Education
{
    public required string Title { get; set; }
    public required string Date { get; set; }
}

public class Experience
{
    public required string JobTitle { get; set; }
    public required string ProjectTitle { get; set; }
    public required string? InitDate { get; set; }
    public required string EndDate { get; set; }
    public required string Description { get; set; }
}

public class MainInfoContent
{
    public required string Name { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required List<Experience> Experience { get; set; }
    public string? ExperienceFootNote { get; set; }
    public required List<Education> Education { get; set; }
    public string? EducationFootNote { get; set; }
}