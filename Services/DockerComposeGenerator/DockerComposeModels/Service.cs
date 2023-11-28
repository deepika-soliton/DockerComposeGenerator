using YamlDotNet.Serialization;

namespace DockerComposeGenerator;

public class Service
{   
    public List<string> Profiles { get; set; } = new List<string>();
    public string Image { get; set; } = string.Empty;
    public Build Build { get; set; } = new Build();

    [YamlMember(Alias = "container_name")]
    public string ContainerName { get; set; } = string.Empty;
    public Dictionary<string, string> Environment { get; set; } = new Dictionary<string, string>();
    public List<string> Ports { get; set; } = new List<string>();
    public List<string> Volumes {get;set;} = new List<string>();
    public List<string> Networks { get; set; } = new List<string>();
    public string Command { get; set; } = string.Empty;

    [YamlMember(Alias = "depends_on")]
    public List<string> DependsOn { get; set; } = new List<string>();
    public RestartPolicy Restart { get; set; } 

    [YamlMember(Alias = "hostname")]
    public string HostName { get; set; } = string.Empty;

    [YamlMember(Alias = "healthcheck")]
    public HealthCheck HealthCheck { get; set; }  = new HealthCheck();  
    public Dictionary<string, string> Labels { get; set; } = new Dictionary<string, string>();
    
    // public List<string> Config { get; set; }
    // public Volume Volumes { get; set; } = new Volume();   
}
