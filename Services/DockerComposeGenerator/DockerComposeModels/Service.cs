namespace DockerComposeGenerator;

public class Service
{
    public string Image { get; set; } = string.Empty;
    public Build Build { get; set; } = new Build();
    public List<string> Volumes {get;set;} = new List<string>();
    public List<string> Profiles { get; set; } = new List<string>();
    public List<string> Ports { get; set; } = new List<string>();
    public Dictionary<string, string> Environment { get; set; } = new Dictionary<string, string>();
    public List<string> Networks { get; set; } = new List<string>();
    public string Command { get; set; } = string.Empty;
    public List<string> Depends_On { get; set; } = new List<string>();
    public RestartPolicy Restart { get; set; } 
    public string ContainerName { get; set; } = string.Empty;
    public string Hostname { get; set; } = string.Empty;
    public HealthCheck Healthcheck { get; set; }  = new HealthCheck();  
    public Dictionary<string, string> Labels { get; set; } = new Dictionary<string, string>();
    
    // public List<string> Config { get; set; }
    // public Volume Volumes { get; set; } = new Volume();   
}
