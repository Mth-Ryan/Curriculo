namespace Curriculo.Data;

public class Content
{
    public required MainInfoContent MainInfo { get; set; }
    public required MainLabels MainLabels { get; set; }
    public required ExtraInfoContent ExtraInfo { get; set; }
    public required ExtraLabels ExtraLabels { get; set; }
}