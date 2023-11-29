using Newtonsoft.Json;

namespace DockerComposeGenerator;

public class DockerComposeModel
{
    [JsonProperty("version")]
    public string Version {get; set;}

    [JsonProperty("services")]
    public  Dictionary<string, Service> Services { get; set; } 

    [JsonProperty("networks")]
    public Dictionary<string, Networks> Networks { get; set; }

    [JsonProperty("volumes")] 
    public Dictionary<string, Volume> Volumes {get;set;} 

    //public Dictionary<string, SecretsAttribute> Secrets {get;set;}
    //public Dictionary<string, ConfigAttribute> Configs {get;set;}

}