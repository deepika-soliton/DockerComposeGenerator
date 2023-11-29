using Newtonsoft.Json;

namespace DockerComposeGenerator;

public class Config
{   
    [JsonProperty("file")]
    public string File { get; set; }

    [JsonProperty("external")]
    public bool External { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("content")]
    public string Content { get; set; }

    [JsonProperty("labels")]
    public Dictionary<string, string> Labels { get; set; } 

    [JsonProperty("driver")]
    public string Driver { get; set; }
}