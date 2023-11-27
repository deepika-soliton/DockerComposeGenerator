namespace DockerComposeGenerator;

public class Build
{
    public string Context { get; set; } = string.Empty;
    public string Dockerfile { get; set; } = string.Empty;
    public Dictionary<string, string> Args { get; set; } = new Dictionary<string, string>();
    public List<string> CacheFrom { get; set; } = new List<string>();
    public Dictionary<string, string> Labels { get; set; } = new Dictionary<string, string>();
}