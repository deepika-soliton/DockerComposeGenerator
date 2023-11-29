using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DockerComposeGenerator;

public class Volume
{   
    [JsonProperty("volumes")]
    public List<string> Volumes {get;set;} 

    [JsonProperty("name")]
    public string Name { get; set; } 

    [JsonProperty("external")]
    public bool External { get; set; }

    [YamlMember(Alias = "driver_opts")]
    [JsonProperty("driver_opts")]
    public Dictionary<string, string> DriverOpts { get; set; }

    [JsonProperty("bind")]
    public string Bind { get; set; } 

    [JsonProperty("type")]
    public string Type { get; set; } 

    [JsonProperty("nocopy")]
    public bool NoCopy { get; set; }

    [JsonProperty("cgroup")]
    public string CGroup { get; set; } 

    [JsonProperty("labels")]
    public Dictionary<string, string> Labels { get; set; } 
}