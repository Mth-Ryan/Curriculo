namespace Curriculo.Data;

public class Content
{
    public required LanguageVariant Variant { get; set; }
    public required MainInfoContent MainInfo { get; set; }
    public required ExtraInfoContent ExtraInfo { get; set; }
}