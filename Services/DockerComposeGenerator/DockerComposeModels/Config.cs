namespace DockerComposeGenerator;

public class Config
{
    public string File { get; set; } = string.Empty;
    public bool External { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public Dictionary<string, string> Labels { get; set; } = new Dictionary<string, string>();
    public string Driver { get; set; } = string.Empty;
}