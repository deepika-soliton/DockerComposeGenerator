using Newtonsoft.Json;

namespace DockerComposeGenerator;

public class HealthCheck
{
    [JsonProperty("test")]
    public List<string> Test { get; set; } 

    [JsonProperty("interval")]
    public string Interval { get; set; } 
    
    [JsonProperty("timeout")]
    public string Timeout { get; set; } 
    
    [JsonProperty("retries")]
    public int Retries { get; set; }
    
    [JsonProperty("startperiod")]
    public string StartPeriod { get; set; } 
    
    [JsonProperty("startinterval")]
    public string StartInterval { get; set; } 
    
    [JsonProperty("disable")]
    public bool Disable {get;set;}
}