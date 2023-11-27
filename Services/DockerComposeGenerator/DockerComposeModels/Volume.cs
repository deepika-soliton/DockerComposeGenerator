namespace DockerComposeGenerator;

public class Volume
{   
    public List<string> Volumes {get;set;} = new List<string>();
    public string Driver { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool External { get; set; }
    public Dictionary<string, string> Driver_Opts { get; set; } = new Dictionary<string, string>();
    public string Bind { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public bool NoCopy { get; set; }
    public string CGroup { get; set; } = string.Empty;
    public Dictionary<string, string> Labels { get; set; } = new Dictionary<string, string>();
}