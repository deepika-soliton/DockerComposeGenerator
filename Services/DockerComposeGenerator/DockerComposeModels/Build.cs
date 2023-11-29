using Newtonsoft.Json;

namespace DockerComposeGenerator;

public class Build
{
    [JsonProperty("context")]
    public string Context { get; set; }

    [JsonProperty("dockerfile")]
    public string Dockerfile { get; set; }

    [JsonProperty("args")]
    public Dictionary<string, string> Args { get; set; }

    [JsonProperty("cachefrom")] 
    public List<string> CacheFrom { get; set; } 

    [JsonProperty("labels")]
    public Dictionary<string, string> Labels { get; set; } 
}