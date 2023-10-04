using System.Text.Json;

namespace Curriculo.Data;

public class ContentsService
{
    private readonly Dictionary<string, Content>? _contents;

    public ContentsService(IConfigurationRoot config)
    {
        var contentsPath = config["Contents:FilePath"];
        var contentsStream = File.Open(contentsPath!, FileMode.Open);
        _contents = JsonSerializer.Deserialize<Dictionary<string, Content>>(contentsStream);
    }

    public bool GetContent(string language, out Content? content)
    {
        if (_contents is null)
        {
            content = null;
            return false;
        }

        return _contents.TryGetValue(language, out  content);
    }
}