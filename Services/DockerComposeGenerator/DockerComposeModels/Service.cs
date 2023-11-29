using YamlDotNet.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DockerComposeGenerator;

public class Service
{   
    [JsonProperty("profiles")]
    public List<string> Profiles { get; set; } 
    
    [JsonProperty("image")]
    public string Image { get; set; } 
    
    [JsonProperty("build")]
    public Build Build { get; set; } 

    [YamlMember(Alias = "container_name")]
    [JsonProperty("container_name")]
    public string ContainerName { get; set; } 
    
    [JsonProperty("environment")]
    public Dictionary<string, string> Environment { get; set; } 
   
    [JsonProperty("ports")]
    public List<string> Ports { get; set; } 

    [JsonProperty("volumes")]
    public List<string> Volumes {get;set;} 

    [JsonProperty("networks")]
    public List<string> Networks { get; set; } 

    [JsonProperty("command")]
    public string Command { get; set; } 

    [YamlMember(Alias = "depends_on")]
    [JsonProperty("depends_on")]
    public List<string> DependsOn { get; set; } 

    [JsonProperty("restart")]
    [JsonConverter(typeof(StringEnumConverter))]
    public RestartPolicy Restart { get; set; } 

    [YamlMember(Alias = "hostname")]
    [JsonProperty("hostname")]
    public string HostName { get; set; } 

    [YamlMember(Alias = "healthcheck")]
    [JsonProperty("healthcheck")]
    public HealthCheck HealthCheck { get; set; } 

    [JsonProperty("labels")]
    public Dictionary<string, string> Labels { get; set; } 
    
    // public List<string> Config { get; set; }
    // public Volume Volumes { get; set; } = new Volume();   
}
